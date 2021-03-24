using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Útnyílvántartás
{
    public partial class Bejelentkezés : Form
    {
        public string userID;
        string username;
        string password;
        usersDataSet DS_users;
        bool success;
        public Bejelentkezés()
        {
            InitializeComponent();
            /*DS_users = new usersDataSet();
            string XMLlocation = Application.StartupPath + @"\XMLuser.xml";
           
            success = false;
            DataTable DT_users = DS_users.Tables["users"];
            DataRow DR_Rows = DT_users.NewRow();

            DR_Rows["ID_User"] = "1";
            DR_Rows["Nev"] = "admin";
            DR_Rows["Jelszo"] = "123";

            DT_users.Rows.Add(DR_Rows);*/
        }



        private void login_Btn_Click(object sender, EventArgs e)
        {
            if(pw_Text.Text.Trim()==jelszoTextBox.Text.Trim())
            {
                user_combo.Text.Trim();
                MainForm mf = new MainForm(Convert.ToInt32(iD_UserTextBox.Text));
                mf.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hiba");
            }
            //usersBindingSource.Filter="Nev = " + user_combo.Text;

            /*
            DataTable DT_SELECT_user = new DataTable();
            string QUERY_SELECT_user = "SELECT * FROM users WHERE Nev=@nev AND Jelszo=@jelszo";

            using (MySqlConnection mysqlcon=new MySqlConnection(DB_Con.constr))
            using (MySqlCommand CMD_SELECT_user = new MySqlCommand(QUERY_SELECT_user,mysqlcon))
            using (MySqlDataAdapter SDA_SELECT_user = new MySqlDataAdapter(CMD_SELECT_user))
            {
                mysqlcon.Open();

                CMD_SELECT_user.Parameters.Add("@nev",MySqlDbType.String).Value = user_combo.Text;
                CMD_SELECT_user.Parameters.Add("@jelszo", MySqlDbType.String).Value = pwTXT.Text;

                SDA_SELECT_user.Fill(DT_SELECT_user);

                if(DT_SELECT_user!=null && DT_SELECT_user.Rows.Count>0)
                {
                    username= user_combo.Text;
                    password = pwTXT.Text;

                    DataRow ROW_userID = DT_SELECT_user.Rows[0];
                    userID = ROW_userID["ID_User"].ToString();

                    MainForm main = new MainForm();
                    main.user_LBL.Text = username +" user ID: "+userID;
                    main.Show();
                    this.Hide();
                }
                else if (DT_SELECT_user != null && DT_SELECT_user.Rows.Count == 0)
                {
                    MessageBox.Show("Rossz felhasználónév, jelszó kombináció!");
                }
            }
            for (int i = 0; i < DS_users.Tables["users"].Rows.Count; i++)
            {
                username = DS_users.Tables["users"].Rows[i]["Nev"].ToString();
                password = DS_users.Tables["users"].Rows[i]["Jelszo"].ToString();

                if(userTXT.Text== username && pwTXT.Text== password)
                {
                    success = true;
                }
                else
                {
                    MessageBox.Show(username + " " + password);
                }
            }
            if(success)
            {
                
                MainForm main = new MainForm();
                main.user_LBL.Text = username;
                main.Show();
                this.Hide();
            }
            else
            {
                //MessageBox.Show(username + " " + password);
                MessageBox.Show("Sikertelen bejelentkezés!");
            }*/
        }

        private void Bejelentkezés_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.users);


        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void pwTXT_TextChanged(object sender, EventArgs e)
        {
            if(pw_Text.Text!="")
            {
                login_Btn.Enabled = true;
            }
            else
            {
                login_Btn.Enabled = false;
            }
        }
    }
}
