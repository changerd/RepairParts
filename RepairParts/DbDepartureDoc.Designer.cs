namespace RepairParts
{
    partial class DbDepartureDoc
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDepartureDocNameDb = new System.Windows.Forms.TextBox();
            this.textBoxDepartureDocSenderDb = new System.Windows.Forms.TextBox();
            this.textBoxDepartureDocRecipentDb = new System.Windows.Forms.TextBox();
            this.dateTimePickerDepartureDocDb = new System.Windows.Forms.DateTimePicker();
            this.buttonDepartureDocAddDb = new System.Windows.Forms.Button();
            this.buttonDepartureDocEditDb = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование документа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отправитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(134, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Получатель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(196, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата:";
            // 
            // textBoxDepartureDocNameDb
            // 
            this.textBoxDepartureDocNameDb.Location = new System.Drawing.Point(259, 12);
            this.textBoxDepartureDocNameDb.Name = "textBoxDepartureDocNameDb";
            this.textBoxDepartureDocNameDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartureDocNameDb.TabIndex = 4;
            // 
            // textBoxDepartureDocSenderDb
            // 
            this.textBoxDepartureDocSenderDb.Location = new System.Drawing.Point(259, 44);
            this.textBoxDepartureDocSenderDb.Name = "textBoxDepartureDocSenderDb";
            this.textBoxDepartureDocSenderDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartureDocSenderDb.TabIndex = 5;
            // 
            // textBoxDepartureDocRecipentDb
            // 
            this.textBoxDepartureDocRecipentDb.Location = new System.Drawing.Point(259, 76);
            this.textBoxDepartureDocRecipentDb.Name = "textBoxDepartureDocRecipentDb";
            this.textBoxDepartureDocRecipentDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartureDocRecipentDb.TabIndex = 6;
            // 
            // dateTimePickerDepartureDocDb
            // 
            this.dateTimePickerDepartureDocDb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepartureDocDb.Location = new System.Drawing.Point(259, 107);
            this.dateTimePickerDepartureDocDb.Name = "dateTimePickerDepartureDocDb";
            this.dateTimePickerDepartureDocDb.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDepartureDocDb.TabIndex = 7;
            // 
            // buttonDepartureDocAddDb
            // 
            this.buttonDepartureDocAddDb.Location = new System.Drawing.Point(153, 161);
            this.buttonDepartureDocAddDb.Name = "buttonDepartureDocAddDb";
            this.buttonDepartureDocAddDb.Size = new System.Drawing.Size(75, 23);
            this.buttonDepartureDocAddDb.TabIndex = 8;
            this.buttonDepartureDocAddDb.Text = "Добавить";
            this.buttonDepartureDocAddDb.UseVisualStyleBackColor = true;
            this.buttonDepartureDocAddDb.Visible = false;
            this.buttonDepartureDocAddDb.Click += new System.EventHandler(this.buttonDepartureDocAddDb_Click);
            // 
            // buttonDepartureDocEditDb
            // 
            this.buttonDepartureDocEditDb.Location = new System.Drawing.Point(143, 161);
            this.buttonDepartureDocEditDb.Name = "buttonDepartureDocEditDb";
            this.buttonDepartureDocEditDb.Size = new System.Drawing.Size(110, 23);
            this.buttonDepartureDocEditDb.TabIndex = 9;
            this.buttonDepartureDocEditDb.Text = "Редактировать";
            this.buttonDepartureDocEditDb.UseVisualStyleBackColor = true;
            this.buttonDepartureDocEditDb.Visible = false;
            this.buttonDepartureDocEditDb.Click += new System.EventHandler(this.buttonDepartureDocEditDb_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(29, 113);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 10;
            // 
            // DbDepartureDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 222);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonDepartureDocEditDb);
            this.Controls.Add(this.buttonDepartureDocAddDb);
            this.Controls.Add(this.dateTimePickerDepartureDocDb);
            this.Controls.Add(this.textBoxDepartureDocRecipentDb);
            this.Controls.Add(this.textBoxDepartureDocSenderDb);
            this.Controls.Add(this.textBoxDepartureDocNameDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DbDepartureDoc";
            this.Text = "DbDepartureDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxDepartureDocNameDb;
        public System.Windows.Forms.TextBox textBoxDepartureDocSenderDb;
        public System.Windows.Forms.TextBox textBoxDepartureDocRecipentDb;
        public System.Windows.Forms.DateTimePicker dateTimePickerDepartureDocDb;
        public System.Windows.Forms.Button buttonDepartureDocAddDb;
        public System.Windows.Forms.Button buttonDepartureDocEditDb;
        public System.Windows.Forms.Label labelId;
    }
}