namespace RepairParts
{
    partial class DbParts
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
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.textBoxPartUnit = new System.Windows.Forms.TextBox();
            this.buttonPartAddDb = new System.Windows.Forms.Button();
            this.buttonPartEditDb = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Еденица измерения:";
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.Location = new System.Drawing.Point(205, 34);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartName.TabIndex = 2;
            // 
            // textBoxPartUnit
            // 
            this.textBoxPartUnit.Location = new System.Drawing.Point(205, 69);
            this.textBoxPartUnit.Name = "textBoxPartUnit";
            this.textBoxPartUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartUnit.TabIndex = 3;
            // 
            // buttonPartAddDb
            // 
            this.buttonPartAddDb.Location = new System.Drawing.Point(122, 109);
            this.buttonPartAddDb.Name = "buttonPartAddDb";
            this.buttonPartAddDb.Size = new System.Drawing.Size(75, 23);
            this.buttonPartAddDb.TabIndex = 4;
            this.buttonPartAddDb.Text = "Добавить";
            this.buttonPartAddDb.UseVisualStyleBackColor = true;
            this.buttonPartAddDb.Visible = false;
            this.buttonPartAddDb.Click += new System.EventHandler(this.buttonPartAddDb_Click);
            // 
            // buttonPartEditDb
            // 
            this.buttonPartEditDb.Location = new System.Drawing.Point(113, 109);
            this.buttonPartEditDb.Name = "buttonPartEditDb";
            this.buttonPartEditDb.Size = new System.Drawing.Size(99, 23);
            this.buttonPartEditDb.TabIndex = 5;
            this.buttonPartEditDb.Text = "Редактировать";
            this.buttonPartEditDb.UseVisualStyleBackColor = true;
            this.buttonPartEditDb.Visible = false;
            this.buttonPartEditDb.Click += new System.EventHandler(this.buttonPartEditDb_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(16, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Visible = false;
            // 
            // DbParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 159);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonPartEditDb);
            this.Controls.Add(this.buttonPartAddDb);
            this.Controls.Add(this.textBoxPartUnit);
            this.Controls.Add(this.textBoxPartName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DbParts";
            this.Text = "DbParts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxPartName;
        public System.Windows.Forms.TextBox textBoxPartUnit;
        public System.Windows.Forms.Button buttonPartAddDb;
        public System.Windows.Forms.Button buttonPartEditDb;
        public System.Windows.Forms.Label labelId;
    }
}