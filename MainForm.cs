using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Útnyílvántartás
{
    public partial class MainForm : Form
    {
        int uid;
        public MainForm(int userID)
        {
            InitializeComponent();
            rogzit_panel.Visible = true;
            kimutatas_panel.Visible = false;
            uid = userID;
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bejelentkezés be = new Bejelentkezés();
            be.Show();
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rogzit_panel.Visible = true;
            kimutatas_panel.Visible = false;
        }

        private void kimutatásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rogzit_panel.Visible = false;
            kimutatas_panel.Visible = true;
        }

        private void rogzit_BTN_Click(object sender, EventArgs e)
        {
            /*Bejelentkezés be = new Bejelentkezés();
            
            string QUERY_INSERT_rogzites = "INSERT INTO utak (ID_user, Datum, Honnan, Hova, km) values (@iduser,@datum,@honnan,@hova,@km)";

            using (MySqlConnection mysqlcon=new MySqlConnection(DB_Con.constr))
            using (MySqlCommand CMD_INSERT_rogzites = new MySqlCommand(QUERY_INSERT_rogzites, mysqlcon))
            {
                mysqlcon.Open();

                CMD_INSERT_rogzites.Parameters.Add("@iduser", MySqlDbType.Int32).Value =Convert.ToInt32(be.userID);
                CMD_INSERT_rogzites.Parameters.Add("@datum", MySqlDbType.Date).Value = dateTimePicker1.Value;
                CMD_INSERT_rogzites.Parameters.Add("@honnan", MySqlDbType.String).Value = honnan_TXT.Text;
                CMD_INSERT_rogzites.Parameters.Add("@hova", MySqlDbType.String).Value = hova_TXT.Text;
                CMD_INSERT_rogzites.Parameters.Add("@km", MySqlDbType.Int32).Value = km_NUM.Value;

                MySqlDataReader READER_INSERT_rogzites = CMD_INSERT_rogzites.ExecuteReader();

                int check = CMD_INSERT_rogzites.ExecuteNonQuery();

                if (check>0)
                {
                    MessageBox.Show("Sikeres rögzítés!");
                }
                else
                {
                    MessageBox.Show("Nem sikerült az adatokat rögzíteni!");
                }

                READER_INSERT_rogzites.Close();

            }

            utakDataSet DS_utak = new utakDataSet();
            string XMLlocation = Application.StartupPath + @"\XMLuser.xml";
            

            DataTable DT_users = DS_utak.Tables["utak"];
            DataRow DR_Rows = DT_users.NewRow();

            DR_Rows["Datum"] = dateTimePicker1.Value;
            DR_Rows["Honnan"] = honnan_TXT.Text;
            DR_Rows["Hova"] = hova_TXT.Text;
            DR_Rows["km"] = km_NUM.Value;

            DT_users.Rows.Add(DR_Rows);*/
        }

        private void tesztToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Bejelentkezés be = new Bejelentkezés();
            be.Show();
        }

        private void utakBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            utakDataGridView.Rows[0].Cells[1].Value = uid;
            this.Validate();
            this.utakBindingSource.EndEdit();
            //this.utakTableAdapter.Fill(this.utakDataSet.utak);
            this.tableAdapterManager.UpdateAll(this.utakDataSet);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utakDataSet.utak' table. You can move, or remove it, as needed.
            this.utakTableAdapter.Fill(this.utakDataSet.utak);
            utakBindingSource.Filter = "ID_User= "+ uid;
        }
        //utakDataGridView.Rows[0].Cells[1].Value = uid;
    }
}
