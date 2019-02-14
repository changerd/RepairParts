namespace RepairParts
{
    partial class DbArrival
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
            this.comboBoxArrivalPartDb = new System.Windows.Forms.ComboBox();
            this.comboBoxArrivalDocDb = new System.Windows.Forms.ComboBox();
            this.textBoxArrivalQuantity = new System.Windows.Forms.TextBox();
            this.textBoxArrivalCost = new System.Windows.Forms.TextBox();
            this.buttonArrivalAddDb = new System.Windows.Forms.Button();
            this.buttonArrivalEditDb = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запчаcть:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Документ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(70, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена:";
            // 
            // comboBoxArrivalPartDb
            // 
            this.comboBoxArrivalPartDb.FormattingEnabled = true;
            this.comboBoxArrivalPartDb.Location = new System.Drawing.Point(136, 14);
            this.comboBoxArrivalPartDb.Name = "comboBoxArrivalPartDb";
            this.comboBoxArrivalPartDb.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArrivalPartDb.TabIndex = 4;
            // 
            // comboBoxArrivalDocDb
            // 
            this.comboBoxArrivalDocDb.FormattingEnabled = true;
            this.comboBoxArrivalDocDb.Location = new System.Drawing.Point(136, 45);
            this.comboBoxArrivalDocDb.Name = "comboBoxArrivalDocDb";
            this.comboBoxArrivalDocDb.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArrivalDocDb.TabIndex = 5;
            // 
            // textBoxArrivalQuantity
            // 
            this.textBoxArrivalQuantity.Location = new System.Drawing.Point(136, 77);
            this.textBoxArrivalQuantity.Name = "textBoxArrivalQuantity";
            this.textBoxArrivalQuantity.Size = new System.Drawing.Size(121, 20);
            this.textBoxArrivalQuantity.TabIndex = 6;
            // 
            // textBoxArrivalCost
            // 
            this.textBoxArrivalCost.Location = new System.Drawing.Point(136, 109);
            this.textBoxArrivalCost.Name = "textBoxArrivalCost";
            this.textBoxArrivalCost.Size = new System.Drawing.Size(121, 20);
            this.textBoxArrivalCost.TabIndex = 7;
            // 
            // buttonArrivalAddDb
            // 
            this.buttonArrivalAddDb.Location = new System.Drawing.Point(115, 154);
            this.buttonArrivalAddDb.Name = "buttonArrivalAddDb";
            this.buttonArrivalAddDb.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivalAddDb.TabIndex = 8;
            this.buttonArrivalAddDb.Text = "Добавить";
            this.buttonArrivalAddDb.UseVisualStyleBackColor = true;
            this.buttonArrivalAddDb.Visible = false;
            this.buttonArrivalAddDb.Click += new System.EventHandler(this.buttonArrivalAddDb_Click);
            // 
            // buttonArrivalEditDb
            // 
            this.buttonArrivalEditDb.Location = new System.Drawing.Point(94, 154);
            this.buttonArrivalEditDb.Name = "buttonArrivalEditDb";
            this.buttonArrivalEditDb.Size = new System.Drawing.Size(113, 23);
            this.buttonArrivalEditDb.TabIndex = 9;
            this.buttonArrivalEditDb.Text = "Редактировать";
            this.buttonArrivalEditDb.UseVisualStyleBackColor = true;
            this.buttonArrivalEditDb.Visible = false;
            this.buttonArrivalEditDb.Click += new System.EventHandler(this.buttonArrivalEditDb_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 1);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Visible = false;
            // 
            // DbArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 200);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonArrivalEditDb);
            this.Controls.Add(this.buttonArrivalAddDb);
            this.Controls.Add(this.textBoxArrivalCost);
            this.Controls.Add(this.textBoxArrivalQuantity);
            this.Controls.Add(this.comboBoxArrivalDocDb);
            this.Controls.Add(this.comboBoxArrivalPartDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DbArrival";
            this.Text = "DbArrival";
            this.Load += new System.EventHandler(this.DbArrival_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxArrivalPartDb;
        public System.Windows.Forms.ComboBox comboBoxArrivalDocDb;
        public System.Windows.Forms.TextBox textBoxArrivalQuantity;
        public System.Windows.Forms.TextBox textBoxArrivalCost;
        public System.Windows.Forms.Button buttonArrivalAddDb;
        public System.Windows.Forms.Button buttonArrivalEditDb;
        public System.Windows.Forms.Label labelId;
    }
}