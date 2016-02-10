using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegFinder.Constants
{
    class Constants
    {
        public const string DB_NAME_KEY = "DbName";
        public const string CONNECTION_STRING = "ConnectionString";

        public const string TABLE_NAME = "RegEntries";
        public static string CREATE_REG_TABLE_COMMAND = string.Format("CREATE TABLE {0} (regEntryID INT, regDate datetime, regOldCourse varchar(100), volumeNo INT, From INT, To INT,)", TABLE_NAME);
        public static string REG_TABLE_EXISTS_SELECT_COMMAND = string.Format("SELECT * FROM {0} WHERE regEntryID = 1", TABLE_NAME);
        public static string REG_ENTRY_EXISTS_SELECT_COMMAND = string.Format("SELECT * FROM {0} WHERE {1} > From and {1} < To", TABLE_NAME);

    }
}
