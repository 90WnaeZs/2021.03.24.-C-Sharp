
namespace Útnyílvántartás
{
    partial class Bejelentkezés
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Btn = new System.Windows.Forms.Button();
            this.usersDataSet = new Útnyílvántartás.usersDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Útnyílvántartás.usersDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new Útnyílvántartás.usersDataSetTableAdapters.TableAdapterManager();
            this.user_combo = new System.Windows.Forms.ComboBox();
            this.iD_UserTextBox = new System.Windows.Forms.TextBox();
            this.jelszoTextBox = new System.Windows.Forms.TextBox();
            this.pw_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(127, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó:";
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_Btn.Location = new System.Drawing.Point(130, 168);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(205, 41);
            this.login_Btn.TabIndex = 4;
            this.login_Btn.Text = "Bejelentkezés";
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "usersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Útnyílvántartás.usersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // user_combo
            // 
            this.user_combo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Nev", true));
            this.user_combo.DataSource = this.usersBindingSource;
            this.user_combo.DisplayMember = "Nev";
            this.user_combo.FormattingEnabled = true;
            this.user_combo.Location = new System.Drawing.Point(131, 65);
            this.user_combo.Name = "user_combo";
            this.user_combo.Size = new System.Drawing.Size(204, 21);
            this.user_combo.TabIndex = 7;
            this.user_combo.ValueMember = "ID_User";
            // 
            // iD_UserTextBox
            // 
            this.iD_UserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ID_User", true));
            this.iD_UserTextBox.Location = new System.Drawing.Point(234, 179);
            this.iD_UserTextBox.Name = "iD_UserTextBox";
            this.iD_UserTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_UserTextBox.TabIndex = 9;
            // 
            // jelszoTextBox
            // 
            this.jelszoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Jelszo", true));
            this.jelszoTextBox.Location = new System.Drawing.Point(131, 179);
            this.jelszoTextBox.Name = "jelszoTextBox";
            this.jelszoTextBox.Size = new System.Drawing.Size(70, 20);
            this.jelszoTextBox.TabIndex = 10;
            // 
            // pw_Text
            // 
            this.pw_Text.Location = new System.Drawing.Point(130, 131);
            this.pw_Text.Name = "pw_Text";
            this.pw_Text.Size = new System.Drawing.Size(204, 20);
            this.pw_Text.TabIndex = 11;
            // 
            // Bejelentkezés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(459, 270);
            this.Controls.Add(this.pw_Text);
            this.Controls.Add(this.user_combo);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jelszoTextBox);
            this.Controls.Add(this.iD_UserTextBox);
            this.Name = "Bejelentkezés";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Bejelentkezés_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_Btn;
        private usersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private usersDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private usersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox user_combo;
        private System.Windows.Forms.TextBox iD_UserTextBox;
        private System.Windows.Forms.TextBox jelszoTextBox;
        private System.Windows.Forms.TextBox pw_Text;
    }
}

