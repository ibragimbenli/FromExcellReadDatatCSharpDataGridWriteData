using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ExcellDataReader
{
    public partial class Exell : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        public Exell()
        {
            InitializeComponent();
        }
        List<string> persons = new List<string>();
        private void btnDataRead_Click(object sender, EventArgs e)
        {
            using (conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ibrahim.benli\Desktop\test.ods; Extended Properties='Ods 12.0 xml;HDR=no;'"))
            {
                //conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                //conn.Close();
            }
        }
    }
}
