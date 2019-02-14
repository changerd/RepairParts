namespace RepairParts
{
    partial class DbDeparture
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDeparturePartDb = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartureDocDb = new System.Windows.Forms.ComboBox();
            this.textBoxDeparureQuantityDb = new System.Windows.Forms.TextBox();
            this.buttonDepartureAddDb = new System.Windows.Forms.Button();
            this.buttonDepartureEdit = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запчасть:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Документ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество:";
            // 
            // comboBoxDeparturePartDb
            // 
            this.comboBoxDeparturePartDb.FormattingEnabled = true;
            this.comboBoxDeparturePartDb.Location = new System.Drawing.Point(132, 9);
            this.comboBoxDeparturePartDb.Name = "comboBoxDeparturePartDb";
            this.comboBoxDeparturePartDb.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeparturePartDb.TabIndex = 3;
            // 
            // comboBoxDepartureDocDb
            // 
            this.comboBoxDepartureDocDb.FormattingEnabled = true;
            this.comboBoxDepartureDocDb.Location = new System.Drawing.Point(132, 47);
            this.comboBoxDepartureDocDb.Name = "comboBoxDepartureDocDb";
            this.comboBoxDepartureDocDb.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartureDocDb.TabIndex = 4;
            // 
            // textBoxDeparureQuantityDb
            // 
            this.textBoxDeparureQuantityDb.Location = new System.Drawing.Point(132, 82);
            this.textBoxDeparureQuantityDb.Name = "textBoxDeparureQuantityDb";
            this.textBoxDeparureQuantityDb.Size = new System.Drawing.Size(121, 20);
            this.textBoxDeparureQuantityDb.TabIndex = 5;
            // 
            // buttonDepartureAddDb
            // 
            this.buttonDepartureAddDb.Location = new System.Drawing.Point(104, 134);
            this.buttonDepartureAddDb.Name = "buttonDepartureAddDb";
            this.buttonDepartureAddDb.Size = new System.Drawing.Size(75, 23);
            this.buttonDepartureAddDb.TabIndex = 6;
            this.buttonDepartureAddDb.Text = "Добавить";
            this.buttonDepartureAddDb.UseVisualStyleBackColor = true;
            this.buttonDepartureAddDb.Visible = false;
            this.buttonDepartureAddDb.Click += new System.EventHandler(this.buttonDepartureAddDb_Click);
            // 
            // buttonDepartureEdit
            // 
            this.buttonDepartureEdit.Location = new System.Drawing.Point(91, 134);
            this.buttonDepartureEdit.Name = "buttonDepartureEdit";
            this.buttonDepartureEdit.Size = new System.Drawing.Size(101, 23);
            this.buttonDepartureEdit.TabIndex = 7;
            this.buttonDepartureEdit.Text = "Редактировать";
            this.buttonDepartureEdit.UseVisualStyleBackColor = true;
            this.buttonDepartureEdit.Visible = false;
            this.buttonDepartureEdit.Click += new System.EventHandler(this.buttonDepartureEdit_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 134);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 8;
            // 
            // DbDeparture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 179);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonDepartureEdit);
            this.Controls.Add(this.buttonDepartureAddDb);
            this.Controls.Add(this.textBoxDeparureQuantityDb);
            this.Controls.Add(this.comboBoxDepartureDocDb);
            this.Controls.Add(this.comboBoxDeparturePartDb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DbDeparture";
            this.Text = "DbDeparture";
            this.Load += new System.EventHandler(this.DbDeparture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxDeparturePartDb;
        public System.Windows.Forms.ComboBox comboBoxDepartureDocDb;
        public System.Windows.Forms.TextBox textBoxDeparureQuantityDb;
        public System.Windows.Forms.Button buttonDepartureAddDb;
        public System.Windows.Forms.Button buttonDepartureEdit;
        public System.Windows.Forms.Label labelId;
    }
}