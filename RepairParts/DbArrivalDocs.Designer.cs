namespace RepairParts
{
    partial class DbArrivalDocs
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
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxArrivalDocName = new System.Windows.Forms.TextBox();
            this.textBoxArrivalDocProvider = new System.Windows.Forms.TextBox();
            this.dateTimePickerArrivalDocDate = new System.Windows.Forms.DateTimePicker();
            this.buttonArrivalDocAddDb = new System.Windows.Forms.Button();
            this.buttonArrivalDocEditDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование документа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поставщик:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(192, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 3;
            // 
            // textBoxArrivalDocName
            // 
            this.textBoxArrivalDocName.Location = new System.Drawing.Point(256, 34);
            this.textBoxArrivalDocName.Name = "textBoxArrivalDocName";
            this.textBoxArrivalDocName.Size = new System.Drawing.Size(100, 20);
            this.textBoxArrivalDocName.TabIndex = 4;
            // 
            // textBoxArrivalDocProvider
            // 
            this.textBoxArrivalDocProvider.Location = new System.Drawing.Point(256, 77);
            this.textBoxArrivalDocProvider.Name = "textBoxArrivalDocProvider";
            this.textBoxArrivalDocProvider.Size = new System.Drawing.Size(100, 20);
            this.textBoxArrivalDocProvider.TabIndex = 5;
            // 
            // dateTimePickerArrivalDocDate
            // 
            this.dateTimePickerArrivalDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArrivalDocDate.Location = new System.Drawing.Point(256, 114);
            this.dateTimePickerArrivalDocDate.Name = "dateTimePickerArrivalDocDate";
            this.dateTimePickerArrivalDocDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerArrivalDocDate.TabIndex = 6;
            // 
            // buttonArrivalDocAddDb
            // 
            this.buttonArrivalDocAddDb.Location = new System.Drawing.Point(152, 167);
            this.buttonArrivalDocAddDb.Name = "buttonArrivalDocAddDb";
            this.buttonArrivalDocAddDb.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivalDocAddDb.TabIndex = 7;
            this.buttonArrivalDocAddDb.Text = "Добавить";
            this.buttonArrivalDocAddDb.UseVisualStyleBackColor = true;
            this.buttonArrivalDocAddDb.Visible = false;
            this.buttonArrivalDocAddDb.Click += new System.EventHandler(this.buttonArrivalDocAddDb_Click);
            // 
            // buttonArrivalDocEditDb
            // 
            this.buttonArrivalDocEditDb.Location = new System.Drawing.Point(139, 167);
            this.buttonArrivalDocEditDb.Name = "buttonArrivalDocEditDb";
            this.buttonArrivalDocEditDb.Size = new System.Drawing.Size(102, 23);
            this.buttonArrivalDocEditDb.TabIndex = 8;
            this.buttonArrivalDocEditDb.Text = "Редактировать";
            this.buttonArrivalDocEditDb.UseVisualStyleBackColor = true;
            this.buttonArrivalDocEditDb.Visible = false;
            this.buttonArrivalDocEditDb.Click += new System.EventHandler(this.buttonArrivalDocEditDb_Click);
            // 
            // DbArrivalDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.Controls.Add(this.buttonArrivalDocEditDb);
            this.Controls.Add(this.buttonArrivalDocAddDb);
            this.Controls.Add(this.dateTimePickerArrivalDocDate);
            this.Controls.Add(this.textBoxArrivalDocProvider);
            this.Controls.Add(this.textBoxArrivalDocName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DbArrivalDocs";
            this.Text = "DbArrivalDocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelId;
        public System.Windows.Forms.TextBox textBoxArrivalDocName;
        public System.Windows.Forms.TextBox textBoxArrivalDocProvider;
        public System.Windows.Forms.DateTimePicker dateTimePickerArrivalDocDate;
        public System.Windows.Forms.Button buttonArrivalDocAddDb;
        public System.Windows.Forms.Button buttonArrivalDocEditDb;
    }
}