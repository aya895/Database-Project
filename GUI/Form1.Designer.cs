using System.Drawing;
using System.Windows.Forms;

namespace BoutiqueHospitalityApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.lblField7 = new System.Windows.Forms.Label();
            this.txtField7 = new System.Windows.Forms.TextBox();
            this.lblField6 = new System.Windows.Forms.Label();
            this.txtField6 = new System.Windows.Forms.TextBox();
            this.lblField5 = new System.Windows.Forms.Label();
            this.txtField5 = new System.Windows.Forms.TextBox();
            this.lblField4 = new System.Windows.Forms.Label();
            this.txtField4 = new System.Windows.Forms.TextBox();
            this.lblField3 = new System.Windows.Forms.Label();
            this.txtField3 = new System.Windows.Forms.TextBox();
            this.lblField2 = new System.Windows.Forms.Label();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.lblField1 = new System.Windows.Forms.Label();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.cboJoins = new System.Windows.Forms.ComboBox();
            this.lblSelectJoin = new System.Windows.Forms.Label();
            this.cboTables = new System.Windows.Forms.ComboBox();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(96)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 60);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(445, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Boutique Hospitality Manager";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.groupBoxMain.Controls.Add(this.lblField7);
            this.groupBoxMain.Controls.Add(this.txtField7);
            this.groupBoxMain.Controls.Add(this.lblField6);
            this.groupBoxMain.Controls.Add(this.txtField6);
            this.groupBoxMain.Controls.Add(this.lblField5);
            this.groupBoxMain.Controls.Add(this.txtField5);
            this.groupBoxMain.Controls.Add(this.lblField4);
            this.groupBoxMain.Controls.Add(this.txtField4);
            this.groupBoxMain.Controls.Add(this.lblField3);
            this.groupBoxMain.Controls.Add(this.txtField3);
            this.groupBoxMain.Controls.Add(this.lblField2);
            this.groupBoxMain.Controls.Add(this.txtField2);
            this.groupBoxMain.Controls.Add(this.lblField1);
            this.groupBoxMain.Controls.Add(this.txtField1);
            this.groupBoxMain.Controls.Add(this.cboJoins);
            this.groupBoxMain.Controls.Add(this.lblSelectJoin);
            this.groupBoxMain.Controls.Add(this.cboTables);
            this.groupBoxMain.Controls.Add(this.lblSelectTable);
            this.groupBoxMain.Controls.Add(this.btnInsert);
            this.groupBoxMain.Controls.Add(this.btnUpdate);
            this.groupBoxMain.Controls.Add(this.btnDelete);
            this.groupBoxMain.Controls.Add(this.btnClear);
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxMain.Location = new System.Drawing.Point(20, 75);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(940, 270);
            this.groupBoxMain.TabIndex = 1;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Data Management CRUD Operations";
            this.groupBoxMain.Enter += new System.EventHandler(this.groupBoxMain_Enter);
            // 
            // lblField7
            // 
            this.lblField7.Location = new System.Drawing.Point(20, 205);
            this.lblField7.Name = "lblField7";
            this.lblField7.Size = new System.Drawing.Size(100, 23);
            this.lblField7.TabIndex = 0;
            this.lblField7.Text = "Field 7:";
            // 
            // txtField7
            // 
            this.txtField7.Location = new System.Drawing.Point(140, 202);
            this.txtField7.Name = "txtField7";
            this.txtField7.Size = new System.Drawing.Size(200, 30);
            this.txtField7.TabIndex = 1;
            // 
            // lblField6
            // 
            this.lblField6.Location = new System.Drawing.Point(380, 165);
            this.lblField6.Name = "lblField6";
            this.lblField6.Size = new System.Drawing.Size(100, 23);
            this.lblField6.TabIndex = 2;
            this.lblField6.Text = "Field 6:";
            // 
            // txtField6
            // 
            this.txtField6.Location = new System.Drawing.Point(530, 162);
            this.txtField6.Name = "txtField6";
            this.txtField6.Size = new System.Drawing.Size(200, 30);
            this.txtField6.TabIndex = 3;
            // 
            // lblField5
            // 
            this.lblField5.Location = new System.Drawing.Point(380, 125);
            this.lblField5.Name = "lblField5";
            this.lblField5.Size = new System.Drawing.Size(100, 23);
            this.lblField5.TabIndex = 4;
            this.lblField5.Text = "Field 5:";
            // 
            // txtField5
            // 
            this.txtField5.Location = new System.Drawing.Point(530, 122);
            this.txtField5.Name = "txtField5";
            this.txtField5.Size = new System.Drawing.Size(200, 30);
            this.txtField5.TabIndex = 5;
            // 
            // lblField4
            // 
            this.lblField4.Location = new System.Drawing.Point(380, 85);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(100, 23);
            this.lblField4.TabIndex = 6;
            this.lblField4.Text = "Field 4:";
            // 
            // txtField4
            // 
            this.txtField4.Location = new System.Drawing.Point(530, 82);
            this.txtField4.Name = "txtField4";
            this.txtField4.Size = new System.Drawing.Size(200, 30);
            this.txtField4.TabIndex = 7;
            // 
            // lblField3
            // 
            this.lblField3.Location = new System.Drawing.Point(20, 165);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(100, 23);
            this.lblField3.TabIndex = 8;
            this.lblField3.Text = "Field 3:";
            // 
            // txtField3
            // 
            this.txtField3.Location = new System.Drawing.Point(140, 162);
            this.txtField3.Name = "txtField3";
            this.txtField3.Size = new System.Drawing.Size(200, 30);
            this.txtField3.TabIndex = 9;
            // 
            // lblField2
            // 
            this.lblField2.Location = new System.Drawing.Point(20, 125);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(100, 23);
            this.lblField2.TabIndex = 10;
            this.lblField2.Text = "Field 2:";
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(140, 122);
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(200, 30);
            this.txtField2.TabIndex = 11;
            // 
            // lblField1
            // 
            this.lblField1.Location = new System.Drawing.Point(20, 85);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(100, 23);
            this.lblField1.TabIndex = 12;
            this.lblField1.Text = "Field 1:";
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(140, 82);
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(200, 30);
            this.txtField1.TabIndex = 13;
            // 
            // cboJoins
            // 
            this.cboJoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJoins.Location = new System.Drawing.Point(450, 32);
            this.cboJoins.Name = "cboJoins";
            this.cboJoins.Size = new System.Drawing.Size(300, 31);
            this.cboJoins.TabIndex = 14;
            this.cboJoins.SelectedIndexChanged += new System.EventHandler(this.cboJoins_SelectedIndexChanged);
            // 
            // lblSelectJoin
            // 
            this.lblSelectJoin.Location = new System.Drawing.Point(350, 35);
            this.lblSelectJoin.Name = "lblSelectJoin";
            this.lblSelectJoin.Size = new System.Drawing.Size(100, 23);
            this.lblSelectJoin.TabIndex = 15;
            this.lblSelectJoin.Text = "Quick Joins:";
            this.lblSelectJoin.Click += new System.EventHandler(this.lblSelectJoin_Click);
            // 
            // cboTables
            // 
            this.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTables.Location = new System.Drawing.Point(120, 32);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(180, 31);
            this.cboTables.TabIndex = 16;
            this.cboTables.SelectedIndexChanged += new System.EventHandler(this.cboTables_SelectedIndexChanged);
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.Location = new System.Drawing.Point(20, 35);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(100, 23);
            this.lblSelectTable.TabIndex = 17;
            this.lblSelectTable.Text = "Select Table:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(96)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsert.Location = new System.Drawing.Point(780, 80);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 35);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(96)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(780, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(780, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 35);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(96)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(780, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeight = 29;
            this.dgvData.Location = new System.Drawing.Point(20, 360);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(940, 280);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(200)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "The Boutique Hospitality Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }
        //    private void InitializeComponent()
        //    {
        //        this.panelTop = new System.Windows.Forms.Panel();
        //        this.lblTitle = new System.Windows.Forms.Label();
        //        this.groupBoxMain = new System.Windows.Forms.GroupBox();
        //        this.lblSelectTable = new System.Windows.Forms.Label();
        //        this.cboTables = new System.Windows.Forms.ComboBox();
        //        this.lblSelectJoin = new System.Windows.Forms.Label();
        //        this.cboJoins = new System.Windows.Forms.ComboBox();
        //        this.lblField1 = new System.Windows.Forms.Label();
        //        this.txtField1 = new System.Windows.Forms.TextBox();
        //        this.lblField2 = new System.Windows.Forms.Label();
        //        this.txtField2 = new System.Windows.Forms.TextBox();
        //        this.lblField3 = new System.Windows.Forms.Label();
        //        this.txtField3 = new System.Windows.Forms.TextBox();
        //        this.lblField4 = new System.Windows.Forms.Label();
        //        this.txtField4 = new System.Windows.Forms.TextBox();
        //        this.lblField5 = new System.Windows.Forms.Label();
        //        this.txtField5 = new System.Windows.Forms.TextBox();
        //        this.lblField6 = new System.Windows.Forms.Label();
        //        this.txtField6 = new System.Windows.Forms.TextBox();
        //        this.lblField7 = new System.Windows.Forms.Label();
        //        this.txtField7 = new System.Windows.Forms.TextBox();
        //        this.btnInsert = new System.Windows.Forms.Button();
        //        this.btnUpdate = new System.Windows.Forms.Button();
        //        this.btnDelete = new System.Windows.Forms.Button();
        //        this.btnClear = new System.Windows.Forms.Button();
        //        this.dgvData = new System.Windows.Forms.DataGridView();

        //        this.panelTop.SuspendLayout();
        //        this.groupBoxMain.SuspendLayout();
        //        ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
        //        this.SuspendLayout();

        //        // panelTop
        //        this.panelTop.Name = "panelTop"; // MUST HAVE THIS
        //        this.panelTop.BackColor = System.Drawing.Color.FromArgb(59, 42, 96);
        //        this.panelTop.Controls.Add(this.lblTitle);
        //        this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        //        this.panelTop.Location = new System.Drawing.Point(0, 0);
        //        this.panelTop.Size = new System.Drawing.Size(984, 60);

        //        // lblTitle
        //        this.lblTitle.Name = "lblTitle";
        //        this.lblTitle.AutoSize = true;
        //        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        //        this.lblTitle.ForeColor = System.Drawing.Color.White;
        //        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        //        this.lblTitle.Text = "Boutique Hospitality Manager";

        //        // groupBoxMain
        //        this.groupBoxMain.Name = "groupBoxMain";
        //        this.groupBoxMain.BackColor = System.Drawing.Color.FromArgb(240, 235, 255);
        //        this.groupBoxMain.Controls.AddRange(new Control[] {
        //    this.lblField7, this.txtField7, this.lblField6, this.txtField6,
        //    this.lblField5, this.txtField5, this.lblField4, this.txtField4,
        //    this.lblField3, this.txtField3, this.lblField2, this.txtField2,
        //    this.lblField1, this.txtField1, this.cboJoins, this.lblSelectJoin,
        //    this.cboTables, this.lblSelectTable, this.btnInsert, this.btnUpdate,
        //    this.btnDelete, this.btnClear
        //});
        //        this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        //        this.groupBoxMain.Location = new System.Drawing.Point(20, 75);
        //        this.groupBoxMain.Size = new System.Drawing.Size(940, 270);
        //        this.groupBoxMain.Text = "Data Management & CRUD Operations";

        //        // Fields - Column 1
        //        this.lblField1.Name = "lblField1"; this.lblField1.Location = new System.Drawing.Point(20, 85); this.lblField1.Text = "Field 1:";
        //        this.txtField1.Name = "txtField1"; this.txtField1.Location = new System.Drawing.Point(140, 82); this.txtField1.Size = new System.Drawing.Size(200, 25);

        //        this.lblField2.Name = "lblField2"; this.lblField2.Location = new System.Drawing.Point(20, 125); this.lblField2.Text = "Field 2:";
        //        this.txtField2.Name = "txtField2"; this.txtField2.Location = new System.Drawing.Point(140, 122); this.txtField2.Size = new System.Drawing.Size(200, 25);

        //        this.lblField3.Name = "lblField3"; this.lblField3.Location = new System.Drawing.Point(20, 165); this.lblField3.Text = "Field 3:";
        //        this.txtField3.Name = "txtField3"; this.txtField3.Location = new System.Drawing.Point(140, 162); this.txtField3.Size = new System.Drawing.Size(200, 25);

        //        this.lblField7.Name = "lblField7"; this.lblField7.Location = new System.Drawing.Point(20, 205); this.lblField7.Text = "Field 7:";
        //        this.txtField7.Name = "txtField7"; this.txtField7.Location = new System.Drawing.Point(140, 202); this.txtField7.Size = new System.Drawing.Size(200, 25);

        //        // Fields - Column 2
        //        this.lblField4.Name = "lblField4"; this.lblField4.Location = new System.Drawing.Point(380, 85); this.lblField4.Text = "Field 4:";
        //        this.txtField4.Name = "txtField4"; this.txtField4.Location = new System.Drawing.Point(530, 82); this.txtField4.Size = new System.Drawing.Size(200, 25);

        //        this.lblField5.Name = "lblField5"; this.lblField5.Location = new System.Drawing.Point(380, 125); this.lblField5.Text = "Field 5:";
        //        this.txtField5.Name = "txtField5"; this.txtField5.Location = new System.Drawing.Point(530, 122); this.txtField5.Size = new System.Drawing.Size(200, 25);

        //        this.lblField6.Name = "lblField6"; this.lblField6.Location = new System.Drawing.Point(380, 165); this.lblField6.Text = "Field 6:";
        //        this.txtField6.Name = "txtField6"; this.txtField6.Location = new System.Drawing.Point(530, 162); this.txtField6.Size = new System.Drawing.Size(200, 25);

        //        // Buttons
        //        this.btnInsert.Name = "btnInsert"; this.btnInsert.BackColor = Color.FromArgb(59, 42, 96); this.btnInsert.ForeColor = Color.White;
        //        this.btnInsert.Location = new System.Drawing.Point(780, 80); this.btnInsert.Size = new System.Drawing.Size(130, 35); this.btnInsert.Text = "Insert";

        //        this.btnUpdate.Name = "btnUpdate"; this.btnUpdate.BackColor = Color.FromArgb(59, 42, 96); this.btnUpdate.ForeColor = Color.White;
        //        this.btnUpdate.Location = new System.Drawing.Point(780, 120); this.btnUpdate.Size = new System.Drawing.Size(130, 35); this.btnUpdate.Text = "Update";

        //        this.btnDelete.Name = "btnDelete"; this.btnDelete.BackColor = Color.FromArgb(59, 42, 96); this.btnDelete.ForeColor = Color.White;
        //        this.btnDelete.Location = new System.Drawing.Point(780, 160); this.btnDelete.Size = new System.Drawing.Size(130, 35); this.btnDelete.Text = "Delete";

        //        this.btnClear.Name = "btnClear"; this.btnClear.BackColor = Color.FromArgb(59, 42, 96); this.btnClear.ForeColor = Color.White;
        //        this.btnClear.Location = new System.Drawing.Point(780, 200); this.btnClear.Size = new System.Drawing.Size(130, 35); this.btnClear.Text = "Clear";

        //        // ComboBoxes
        //        this.lblSelectTable.Name = "lblSelectTable"; this.lblSelectTable.Location = new System.Drawing.Point(20, 35); this.lblSelectTable.Text = "Select Table:";
        //        this.cboTables.Name = "cboTables"; this.cboTables.Location = new System.Drawing.Point(120, 32); this.cboTables.Size = new System.Drawing.Size(180, 25);
        //        this.cboTables.DropDownStyle = ComboBoxStyle.DropDownList;

        //        this.lblSelectJoin.Name = "lblSelectJoin"; this.lblSelectJoin.Location = new System.Drawing.Point(350, 35); this.lblSelectJoin.Text = "Quick Joins:";
        //        this.cboJoins.Name = "cboJoins"; this.cboJoins.Location = new System.Drawing.Point(450, 32); this.cboJoins.Size = new System.Drawing.Size(300, 25);
        //        this.cboJoins.DropDownStyle = ComboBoxStyle.DropDownList;

        //        // DataGridView
        //        this.dgvData.Name = "dgvData";
        //        this.dgvData.BackgroundColor = System.Drawing.Color.White;
        //        this.dgvData.Location = new System.Drawing.Point(20, 360);
        //        this.dgvData.Size = new System.Drawing.Size(940, 280);

        //        // Form
        //        this.Name = "Form1";
        //        this.BackColor = System.Drawing.Color.FromArgb(211, 197, 246);
        //        this.ClientSize = new System.Drawing.Size(984, 661);
        //        this.Controls.Add(this.dgvData);
        //        this.Controls.Add(this.groupBoxMain);
        //        this.Controls.Add(this.panelTop);
        //        this.Text = "The Boutique Hospitality Manager";

        //        this.panelTop.ResumeLayout(false);
        //        this.panelTop.PerformLayout();
        //        this.groupBoxMain.ResumeLayout(false);
        //        this.groupBoxMain.PerformLayout();
        //        ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
        //        this.ResumeLayout(false);
        //    }

        //// Helper methods to keep the designer clean
        //private void SetupField(System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt, int lx, int tx, int y)
        //{
        //    lbl.Location = new System.Drawing.Point(lx, y);
        //    lbl.AutoSize = true;
        //    txt.Location = new System.Drawing.Point(tx, y - 3);
        //    txt.Size = new System.Drawing.Size(200, 25);
        //}

        //private void SetupButton(System.Windows.Forms.Button btn, string text, int x, int y)
        //{
        //    btn.Text = text;
        //    btn.Location = new System.Drawing.Point(x, y);
        //    btn.Size = new System.Drawing.Size(130, 35);
        //    btn.BackColor = System.Drawing.Color.FromArgb(59, 42, 96);
        //    btn.ForeColor = System.Drawing.Color.White;
        //    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //}

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.ComboBox cboTables;
        private System.Windows.Forms.Label lblSelectJoin;
        private System.Windows.Forms.ComboBox cboJoins;
        private System.Windows.Forms.Label lblField1;
        private System.Windows.Forms.TextBox txtField1;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.TextBox txtField2;
        private System.Windows.Forms.Label lblField3;
        private System.Windows.Forms.TextBox txtField3;
        private System.Windows.Forms.Label lblField4;
        private System.Windows.Forms.TextBox txtField4;
        private System.Windows.Forms.Label lblField5;
        private System.Windows.Forms.TextBox txtField5;
        private System.Windows.Forms.Label lblField6;
        private System.Windows.Forms.TextBox txtField6;
        private System.Windows.Forms.Label lblField7; 
        private System.Windows.Forms.TextBox txtField7; 
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvData;
    }
}