
namespace Útnyílvántartás
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rögzítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kimutatásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesztToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rogzit_panel = new System.Windows.Forms.Panel();
            this.utakDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utakDataSet = new Útnyílvántartás.utakDataSet();
            this.rogzit_BTN = new System.Windows.Forms.Button();
            this.user_LBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.km_NUM = new System.Windows.Forms.NumericUpDown();
            this.hova_TXT = new System.Windows.Forms.TextBox();
            this.honnan_TXT = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kimutatas_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.utakTableAdapter = new Útnyílvántartás.utakDataSetTableAdapters.utakTableAdapter();
            this.tableAdapterManager = new Útnyílvántartás.utakDataSetTableAdapters.TableAdapterManager();
            this.utakBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.utakBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.rogzit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utakDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.km_NUM)).BeginInit();
            this.kimutatas_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utakBindingNavigator)).BeginInit();
            this.utakBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rögzítésToolStripMenuItem,
            this.kimutatásokToolStripMenuItem,
            this.kilépésToolStripMenuItem,
            this.tesztToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rögzítésToolStripMenuItem
            // 
            this.rögzítésToolStripMenuItem.Name = "rögzítésToolStripMenuItem";
            this.rögzítésToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rögzítésToolStripMenuItem.Text = "Rögzítés";
            this.rögzítésToolStripMenuItem.Click += new System.EventHandler(this.rögzítésToolStripMenuItem_Click);
            // 
            // kimutatásokToolStripMenuItem
            // 
            this.kimutatásokToolStripMenuItem.Name = "kimutatásokToolStripMenuItem";
            this.kimutatásokToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.kimutatásokToolStripMenuItem.Text = "Kimutatások";
            this.kimutatásokToolStripMenuItem.Click += new System.EventHandler(this.kimutatásokToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // tesztToolStripMenuItem
            // 
            this.tesztToolStripMenuItem.Name = "tesztToolStripMenuItem";
            this.tesztToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tesztToolStripMenuItem.Text = "teszt";
            this.tesztToolStripMenuItem.Click += new System.EventHandler(this.tesztToolStripMenuItem_Click);
            // 
            // rogzit_panel
            // 
            this.rogzit_panel.Controls.Add(this.kimutatas_panel);
            this.rogzit_panel.Controls.Add(this.utakDataGridView);
            this.rogzit_panel.Controls.Add(this.rogzit_BTN);
            this.rogzit_panel.Controls.Add(this.user_LBL);
            this.rogzit_panel.Controls.Add(this.label5);
            this.rogzit_panel.Controls.Add(this.label4);
            this.rogzit_panel.Controls.Add(this.label3);
            this.rogzit_panel.Controls.Add(this.label2);
            this.rogzit_panel.Controls.Add(this.km_NUM);
            this.rogzit_panel.Controls.Add(this.hova_TXT);
            this.rogzit_panel.Controls.Add(this.honnan_TXT);
            this.rogzit_panel.Controls.Add(this.dateTimePicker1);
            this.rogzit_panel.Location = new System.Drawing.Point(13, 42);
            this.rogzit_panel.Name = "rogzit_panel";
            this.rogzit_panel.Size = new System.Drawing.Size(1028, 396);
            this.rogzit_panel.TabIndex = 1;
            // 
            // utakDataGridView
            // 
            this.utakDataGridView.AutoGenerateColumns = false;
            this.utakDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utakDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.utakDataGridView.DataSource = this.utakBindingSource;
            this.utakDataGridView.Location = new System.Drawing.Point(254, 38);
            this.utakDataGridView.Name = "utakDataGridView";
            this.utakDataGridView.Size = new System.Drawing.Size(648, 262);
            this.utakDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ut";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_ut";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_user";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_user";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Honnan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Honnan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hova";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hova";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "km";
            this.dataGridViewTextBoxColumn6.HeaderText = "km";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // utakBindingSource
            // 
            this.utakBindingSource.DataMember = "utak";
            this.utakBindingSource.DataSource = this.utakDataSet;
            // 
            // utakDataSet
            // 
            this.utakDataSet.DataSetName = "utakDataSet";
            this.utakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rogzit_BTN
            // 
            this.rogzit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rogzit_BTN.Location = new System.Drawing.Point(6, 289);
            this.rogzit_BTN.Name = "rogzit_BTN";
            this.rogzit_BTN.Size = new System.Drawing.Size(200, 47);
            this.rogzit_BTN.TabIndex = 12;
            this.rogzit_BTN.Text = "Rögzítés";
            this.rogzit_BTN.UseVisualStyleBackColor = true;
            this.rogzit_BTN.Click += new System.EventHandler(this.rogzit_BTN_Click);
            // 
            // user_LBL
            // 
            this.user_LBL.AutoSize = true;
            this.user_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_LBL.Location = new System.Drawing.Point(3, 9);
            this.user_LBL.Name = "user_LBL";
            this.user_LBL.Size = new System.Drawing.Size(100, 17);
            this.user_LBL.TabIndex = 11;
            this.user_LBL.Text = "Bejelentkezve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Km:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hova:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Honnan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dátum:";
            // 
            // km_NUM
            // 
            this.km_NUM.Location = new System.Drawing.Point(6, 235);
            this.km_NUM.Name = "km_NUM";
            this.km_NUM.Size = new System.Drawing.Size(200, 20);
            this.km_NUM.TabIndex = 6;
            // 
            // hova_TXT
            // 
            this.hova_TXT.Location = new System.Drawing.Point(6, 169);
            this.hova_TXT.Name = "hova_TXT";
            this.hova_TXT.Size = new System.Drawing.Size(200, 20);
            this.hova_TXT.TabIndex = 5;
            // 
            // honnan_TXT
            // 
            this.honnan_TXT.Location = new System.Drawing.Point(6, 110);
            this.honnan_TXT.Name = "honnan_TXT";
            this.honnan_TXT.Size = new System.Drawing.Size(200, 20);
            this.honnan_TXT.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // kimutatas_panel
            // 
            this.kimutatas_panel.Controls.Add(this.label1);
            this.kimutatas_panel.Location = new System.Drawing.Point(950, 0);
            this.kimutatas_panel.Name = "kimutatas_panel";
            this.kimutatas_panel.Size = new System.Drawing.Size(467, 396);
            this.kimutatas_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // utakTableAdapter
            // 
            this.utakTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Útnyílvántartás.utakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utakTableAdapter = this.utakTableAdapter;
            // 
            // utakBindingNavigator
            // 
            this.utakBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.utakBindingNavigator.BindingSource = this.utakBindingSource;
            this.utakBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.utakBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.utakBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.utakBindingNavigatorSaveItem});
            this.utakBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.utakBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.utakBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.utakBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.utakBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.utakBindingNavigator.Name = "utakBindingNavigator";
            this.utakBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.utakBindingNavigator.Size = new System.Drawing.Size(1275, 25);
            this.utakBindingNavigator.TabIndex = 3;
            this.utakBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // utakBindingNavigatorSaveItem
            // 
            this.utakBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.utakBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("utakBindingNavigatorSaveItem.Image")));
            this.utakBindingNavigatorSaveItem.Name = "utakBindingNavigatorSaveItem";
            this.utakBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.utakBindingNavigatorSaveItem.Text = "Save Data";
            this.utakBindingNavigatorSaveItem.Click += new System.EventHandler(this.utakBindingNavigatorSaveItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 450);
            this.Controls.Add(this.utakBindingNavigator);
            this.Controls.Add(this.rogzit_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rogzit_panel.ResumeLayout(false);
            this.rogzit_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utakDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.km_NUM)).EndInit();
            this.kimutatas_panel.ResumeLayout(false);
            this.kimutatas_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utakBindingNavigator)).EndInit();
            this.utakBindingNavigator.ResumeLayout(false);
            this.utakBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rögzítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kimutatásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Panel rogzit_panel;
        private System.Windows.Forms.Panel kimutatas_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown km_NUM;
        private System.Windows.Forms.TextBox hova_TXT;
        private System.Windows.Forms.TextBox honnan_TXT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button rogzit_BTN;
        public System.Windows.Forms.Label user_LBL;
        private System.Windows.Forms.ToolStripMenuItem tesztToolStripMenuItem;
        private utakDataSet utakDataSet;
        private System.Windows.Forms.BindingSource utakBindingSource;
        private utakDataSetTableAdapters.utakTableAdapter utakTableAdapter;
        private utakDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator utakBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton utakBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView utakDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}