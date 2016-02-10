using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegFinder.DAL;

namespace RegFinder
{
    public partial class MainForm : Form
    {
        private SqliteDal _dal;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            _dal = new SqliteDal(new ConfigHelper());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddEntries_Click(object sender, EventArgs e)
        {

        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
