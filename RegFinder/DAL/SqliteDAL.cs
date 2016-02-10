using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.IO;
using RegFinder.Constants;
using System.Configuration;

namespace RegFinder.DAL
{
    public class SqliteDal : IDisposable
    {
        private IConfigHelper _configHelper = null;
        private static string _connectionString = string.Empty;
        private static string _dbName = string.Empty;

        public SqliteDal(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
            _connectionString = _configHelper.GetValue(Constants.Constants.CONNECTION_STRING);
            _dbName = _configHelper.GetValue(Constants.Constants.DB_NAME_KEY);
            Init();
        }

        private void Init()
        {
            CreateDBIfNotExists();
            CreateTableIfNotPresent();
        }

        private void CreateDBIfNotExists(bool recreate = false)
        {
            if (!IsDbPresent() || recreate)
            {
                SQLiteConnection.CreateFile(_dbName);
            }
        }

        /// <summary> 
        /// Returns datatbale for given sql query. 
        /// </summary> 
        /// <param name="sql"></param> 
        /// <returns></returns> 
        public static DataTable getData(string sql)
        {
            SQLiteConnection cn = new SQLiteConnection(_connectionString);
            try
            {
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand(sql, cn);
                SQLiteDataReader dr = cm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                cn.Close();
                throw ex;
            }
        }

        /// <summary> 
        /// Returns count of executed insert, update, delete statement. 
        /// </summary> 
        /// <param name="sql"></param> 
        /// <returns></returns> 
        public static int execNQ(string sql)
        {
            SQLiteConnection cn = new SQLiteConnection(_connectionString);
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand(sql, cn);
            int rows;
            rows = cm.ExecuteNonQuery();
            cn.Close();
            return rows;
        }

        /// <summary> 
        /// Returns scalar for given sql query. 
        /// </summary> 
        /// <param name="sql"></param> 
        /// <returns></returns> 
        public static object execSC(string sql)
        {
            SQLiteConnection cn = new SQLiteConnection(_connectionString);
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand(sql, cn);
            object rows;
            rows = cm.ExecuteScalar();
            cn.Close();
            if (rows == null)
            {
                rows = 0;
            }
            return rows;
        }

        public static bool IsDbPresent()
        {
            if (!(Path.GetInvalidFileNameChars().Length > 0))
                return File.Exists(_dbName);
            return false;
        }

        public static void CreateTableIfNotPresent(bool flushAllData = false)
        {
            string selectCommand = Constants.Constants.REG_TABLE_EXISTS_SELECT_COMMAND;
            string createTableCommand = Constants.Constants.CREATE_REG_TABLE_COMMAND;
            object dataRetrieved = execSC(selectCommand);
            if (dataRetrieved == null || flushAllData)
            {
                execNQ(createTableCommand);
            }
        }

        public void Dispose()
        {
            _configHelper = null;
        }
    }

    public interface IConfigHelper
    {
        void ReadConfig();
        void AddKey(string key, string value);
        string GetValue(string key);
    }

    public class ConfigReader
    {
        private const string DB_NAME = "DbName";
        private static IConfigHelper _configHelper;

        public ConfigReader(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }
        public static string DbName
        {
            get
            {
                return _configHelper.GetValue(DB_NAME);

            }
            set
            {
                _configHelper.AddKey(DB_NAME, value);

            }
        }
    }

    public class ConfigHelper : IConfigHelper
    {
        public IDictionary<string, string> ConfigEntries { get; set; }

        public void AddKey(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!configuration.AppSettings.Settings.AllKeys.Contains(key))
                configuration.AppSettings.Settings.Add(key, value);
            else
                configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
        }

        public string GetValue(string key)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings[key].Value ?? null;
        }

        public string DbName
        {
            get
            {
                return GetValue("DbName");
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    AddKey("DbName", value);
            }
        }

        public void ReadConfig()
        {

        }
    }
}
