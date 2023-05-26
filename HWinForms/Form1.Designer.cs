namespace HWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LBQuestionary = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(3, 3);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(103, 23);
            this.TBName.TabIndex = 0;
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(3, 39);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(103, 23);
            this.TBSurname.TabIndex = 1;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(3, 75);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(103, 23);
            this.TBEmail.TabIndex = 2;
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(3, 111);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(103, 23);
            this.TBNumber.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(3, 147);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(103, 30);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.AddQuestionary);
            // 
            // LBQuestionary
            // 
            this.LBQuestionary.FormattingEnabled = true;
            this.LBQuestionary.ItemHeight = 15;
            this.LBQuestionary.Location = new System.Drawing.Point(12, 12);
            this.LBQuestionary.Name = "LBQuestionary";
            this.LBQuestionary.Size = new System.Drawing.Size(192, 289);
            this.LBQuestionary.TabIndex = 5;
            this.LBQuestionary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBQuestionary_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.ColumnCount = 1;
            this.RightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightPanel.Controls.Add(this.BtnEdit, 0, 7);
            this.RightPanel.Controls.Add(this.TBName, 0, 0);
            this.RightPanel.Controls.Add(this.btnSave, 0, 5);
            this.RightPanel.Controls.Add(this.TBSurname, 0, 1);
            this.RightPanel.Controls.Add(this.TBEmail, 0, 2);
            this.RightPanel.Controls.Add(this.ButtonAdd, 0, 4);
            this.RightPanel.Controls.Add(this.TBNumber, 0, 3);
            this.RightPanel.Controls.Add(this.BtnDelete, 0, 6);
            this.RightPanel.Location = new System.Drawing.Point(210, 12);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.RowCount = 8;
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RightPanel.Size = new System.Drawing.Size(109, 289);
            this.RightPanel.TabIndex = 7;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(3, 255);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(103, 31);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Редактировать";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(3, 219);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 30);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 323);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LBQuestionary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TBName;
        private TextBox TBSurname;
        private TextBox TBEmail;
        private TextBox TBNumber;
        private Button ButtonAdd;
        private ListBox LBQuestionary;
        private Button btnSave;
        private TableLayoutPanel RightPanel;
        private Button BtnEdit;
        private Button BtnDelete;
    }
}