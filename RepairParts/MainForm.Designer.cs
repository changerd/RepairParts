namespace RepairParts
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPartDelete = new System.Windows.Forms.Button();
            this.buttonPartEdit = new System.Windows.Forms.Button();
            this.buttonPartAdd = new System.Windows.Forms.Button();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewArrivalDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewArrival = new System.Windows.Forms.DataGridView();
            this.buttonArrivalDocAdd = new System.Windows.Forms.Button();
            this.buttonArrivalDocEdit = new System.Windows.Forms.Button();
            this.buttonArrivalDocDelete = new System.Windows.Forms.Button();
            this.buttonArrivalAdd = new System.Windows.Forms.Button();
            this.buttonArrivalEdit = new System.Windows.Forms.Button();
            this.buttonArrivalDelete = new System.Windows.Forms.Button();
            this.dataGridViewDepartureDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewDeparture = new System.Windows.Forms.DataGridView();
            this.buttonDepartureDocAdd = new System.Windows.Forms.Button();
            this.buttonDepartureDocEdit = new System.Windows.Forms.Button();
            this.buttonDepartureDocDelete = new System.Windows.Forms.Button();
            this.buttonDepartureAdd = new System.Windows.Forms.Button();
            this.buttonDepartureEdit = new System.Windows.Forms.Button();
            this.buttonDepartureDelete = new System.Windows.Forms.Button();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivalDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeparture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPartDelete);
            this.tabPage1.Controls.Add(this.buttonPartEdit);
            this.tabPage1.Controls.Add(this.buttonPartAdd);
            this.tabPage1.Controls.Add(this.dataGridViewParts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запчасти";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonPartDelete
            // 
            this.buttonPartDelete.Location = new System.Drawing.Point(527, 268);
            this.buttonPartDelete.Name = "buttonPartDelete";
            this.buttonPartDelete.Size = new System.Drawing.Size(121, 50);
            this.buttonPartDelete.TabIndex = 3;
            this.buttonPartDelete.Text = "Удалить";
            this.buttonPartDelete.UseVisualStyleBackColor = true;
            this.buttonPartDelete.Click += new System.EventHandler(this.buttonPartDelete_Click);
            // 
            // buttonPartEdit
            // 
            this.buttonPartEdit.Location = new System.Drawing.Point(527, 156);
            this.buttonPartEdit.Name = "buttonPartEdit";
            this.buttonPartEdit.Size = new System.Drawing.Size(121, 50);
            this.buttonPartEdit.TabIndex = 2;
            this.buttonPartEdit.Text = "Редактировать";
            this.buttonPartEdit.UseVisualStyleBackColor = true;
            this.buttonPartEdit.Click += new System.EventHandler(this.buttonPartEdit_Click);
            // 
            // buttonPartAdd
            // 
            this.buttonPartAdd.Location = new System.Drawing.Point(527, 22);
            this.buttonPartAdd.Name = "buttonPartAdd";
            this.buttonPartAdd.Size = new System.Drawing.Size(121, 50);
            this.buttonPartAdd.TabIndex = 1;
            this.buttonPartAdd.Text = "Добавить";
            this.buttonPartAdd.UseVisualStyleBackColor = true;
            this.buttonPartAdd.Click += new System.EventHandler(this.buttonPartAdd_Click);
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.Size = new System.Drawing.Size(397, 373);
            this.dataGridViewParts.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonArrivalDelete);
            this.tabPage2.Controls.Add(this.buttonArrivalEdit);
            this.tabPage2.Controls.Add(this.buttonArrivalAdd);
            this.tabPage2.Controls.Add(this.buttonArrivalDocDelete);
            this.tabPage2.Controls.Add(this.buttonArrivalDocEdit);
            this.tabPage2.Controls.Add(this.buttonArrivalDocAdd);
            this.tabPage2.Controls.Add(this.dataGridViewArrival);
            this.tabPage2.Controls.Add(this.dataGridViewArrivalDoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поступление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDepartureDelete);
            this.tabPage3.Controls.Add(this.buttonDepartureEdit);
            this.tabPage3.Controls.Add(this.buttonDepartureAdd);
            this.tabPage3.Controls.Add(this.buttonDepartureDocDelete);
            this.tabPage3.Controls.Add(this.buttonDepartureDocEdit);
            this.tabPage3.Controls.Add(this.buttonDepartureDocAdd);
            this.tabPage3.Controls.Add(this.dataGridViewDeparture);
            this.tabPage3.Controls.Add(this.dataGridViewDepartureDoc);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Списание";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // dataGridViewArrivalDoc
            // 
            this.dataGridViewArrivalDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrivalDoc.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewArrivalDoc.Name = "dataGridViewArrivalDoc";
            this.dataGridViewArrivalDoc.Size = new System.Drawing.Size(589, 111);
            this.dataGridViewArrivalDoc.TabIndex = 0;
            // 
            // dataGridViewArrival
            // 
            this.dataGridViewArrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrival.Location = new System.Drawing.Point(6, 123);
            this.dataGridViewArrival.Name = "dataGridViewArrival";
            this.dataGridViewArrival.Size = new System.Drawing.Size(756, 227);
            this.dataGridViewArrival.TabIndex = 1;
            // 
            // buttonArrivalDocAdd
            // 
            this.buttonArrivalDocAdd.Location = new System.Drawing.Point(647, 17);
            this.buttonArrivalDocAdd.Name = "buttonArrivalDocAdd";
            this.buttonArrivalDocAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivalDocAdd.TabIndex = 2;
            this.buttonArrivalDocAdd.Text = "Добавить";
            this.buttonArrivalDocAdd.UseVisualStyleBackColor = true;
            this.buttonArrivalDocAdd.Click += new System.EventHandler(this.buttonArrivalDocAdd_Click);
            // 
            // buttonArrivalDocEdit
            // 
            this.buttonArrivalDocEdit.Location = new System.Drawing.Point(633, 46);
            this.buttonArrivalDocEdit.Name = "buttonArrivalDocEdit";
            this.buttonArrivalDocEdit.Size = new System.Drawing.Size(99, 23);
            this.buttonArrivalDocEdit.TabIndex = 3;
            this.buttonArrivalDocEdit.Text = "Редактировать";
            this.buttonArrivalDocEdit.UseVisualStyleBackColor = true;
            this.buttonArrivalDocEdit.Click += new System.EventHandler(this.buttonArrivalDocEdit_Click);
            // 
            // buttonArrivalDocDelete
            // 
            this.buttonArrivalDocDelete.Location = new System.Drawing.Point(647, 75);
            this.buttonArrivalDocDelete.Name = "buttonArrivalDocDelete";
            this.buttonArrivalDocDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivalDocDelete.TabIndex = 4;
            this.buttonArrivalDocDelete.Text = "Удалить";
            this.buttonArrivalDocDelete.UseVisualStyleBackColor = true;
            this.buttonArrivalDocDelete.Click += new System.EventHandler(this.buttonArrivalDocDelete_Click);
            // 
            // buttonArrivalAdd
            // 
            this.buttonArrivalAdd.Location = new System.Drawing.Point(6, 356);
            this.buttonArrivalAdd.Name = "buttonArrivalAdd";
            this.buttonArrivalAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivalAdd.TabIndex = 5;
            this.buttonArrivalAdd.Text = "Добавить";
            this.buttonArrivalAdd.UseVisualStyleBackColor = true;
            this.buttonArrivalAdd.Click += new System.EventHandler(this.buttonArrivalAdd_Click);
            // 
            // buttonArrivalEdit
            // 
            this.buttonArrivalEdit.Location = new System.Drawing.Point(87, 356);
            this.buttonArrivalEdit.Name = "buttonArrivalEdit";
            this.buttonArrivalEdit.Size = new System.Drawing.Size(104, 23);
            this.buttonArrivalEdit.TabIndex = 6;
            this.buttonArrivalEdit.Text = "Редактировать";
            this.buttonArrivalEdit.UseVisualStyleBackColor = true;
            this.buttonArrivalEdit.Click += new System.EventHandler(this.buttonArrivalEdit_Click);
            // 
            // buttonArrivalDelete
            // 
            this.buttonArrivalDelete.Location = new System.Drawing.Point(197, 356);
            this.buttonArrivalDelete.Name = "buttonArrivalDelete";
            this.buttonArrivalDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivalDelete.TabIndex = 7;
            this.buttonArrivalDelete.Text = "Удалить";
            this.buttonArrivalDelete.UseVisualStyleBackColor = true;
            this.buttonArrivalDelete.Click += new System.EventHandler(this.buttonArrivalDelete_Click);
            // 
            // dataGridViewDepartureDoc
            // 
            this.dataGridViewDepartureDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartureDoc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDepartureDoc.Name = "dataGridViewDepartureDoc";
            this.dataGridViewDepartureDoc.Size = new System.Drawing.Size(618, 133);
            this.dataGridViewDepartureDoc.TabIndex = 0;
            // 
            // dataGridViewDeparture
            // 
            this.dataGridViewDeparture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeparture.Location = new System.Drawing.Point(3, 142);
            this.dataGridViewDeparture.Name = "dataGridViewDeparture";
            this.dataGridViewDeparture.Size = new System.Drawing.Size(762, 209);
            this.dataGridViewDeparture.TabIndex = 1;
            // 
            // buttonDepartureDocAdd
            // 
            this.buttonDepartureDocAdd.Location = new System.Drawing.Point(661, 26);
            this.buttonDepartureDocAdd.Name = "buttonDepartureDocAdd";
            this.buttonDepartureDocAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonDepartureDocAdd.TabIndex = 2;
            this.buttonDepartureDocAdd.Text = "Добавить";
            this.buttonDepartureDocAdd.UseVisualStyleBackColor = true;
            this.buttonDepartureDocAdd.Click += new System.EventHandler(this.buttonDepartureDocAdd_Click);
            // 
            // buttonDepartureDocEdit
            // 
            this.buttonDepartureDocEdit.Location = new System.Drawing.Point(642, 55);
            this.buttonDepartureDocEdit.Name = "buttonDepartureDocEdit";
            this.buttonDepartureDocEdit.Size = new System.Drawing.Size(114, 23);
            this.buttonDepartureDocEdit.TabIndex = 3;
            this.buttonDepartureDocEdit.Text = "Редактировать";
            this.buttonDepartureDocEdit.UseVisualStyleBackColor = true;
            this.buttonDepartureDocEdit.Click += new System.EventHandler(this.buttonDepartureDocEdit_Click);
            // 
            // buttonDepartureDocDelete
            // 
            this.buttonDepartureDocDelete.Location = new System.Drawing.Point(661, 84);
            this.buttonDepartureDocDelete.Name = "buttonDepartureDocDelete";
            this.buttonDepartureDocDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDepartureDocDelete.TabIndex = 4;
            this.buttonDepartureDocDelete.Text = "Удалить";
            this.buttonDepartureDocDelete.UseVisualStyleBackColor = true;
            this.buttonDepartureDocDelete.Click += new System.EventHandler(this.buttonDepartureDocDelete_Click);
            // 
            // buttonDepartureAdd
            // 
            this.buttonDepartureAdd.Location = new System.Drawing.Point(3, 357);
            this.buttonDepartureAdd.Name = "buttonDepartureAdd";
            this.buttonDepartureAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonDepartureAdd.TabIndex = 5;
            this.buttonDepartureAdd.Text = "Добавить";
            this.buttonDepartureAdd.UseVisualStyleBackColor = true;
            this.buttonDepartureAdd.Click += new System.EventHandler(this.buttonDepartureAdd_Click);
            // 
            // buttonDepartureEdit
            // 
            this.buttonDepartureEdit.Location = new System.Drawing.Point(85, 358);
            this.buttonDepartureEdit.Name = "buttonDepartureEdit";
            this.buttonDepartureEdit.Size = new System.Drawing.Size(100, 23);
            this.buttonDepartureEdit.TabIndex = 6;
            this.buttonDepartureEdit.Text = "Редактировать";
            this.buttonDepartureEdit.UseVisualStyleBackColor = true;
            this.buttonDepartureEdit.Click += new System.EventHandler(this.buttonDepartureEdit_Click);
            // 
            // buttonDepartureDelete
            // 
            this.buttonDepartureDelete.Location = new System.Drawing.Point(191, 357);
            this.buttonDepartureDelete.Name = "buttonDepartureDelete";
            this.buttonDepartureDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDepartureDelete.TabIndex = 7;
            this.buttonDepartureDelete.Text = "Удалить";
            this.buttonDepartureDelete.UseVisualStyleBackColor = true;
            this.buttonDepartureDelete.Click += new System.EventHandler(this.buttonDepartureDelete_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Автоматизация учёта запасных частей ОАО \"Гомельоблагросервис\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivalDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeparture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonPartDelete;
        private System.Windows.Forms.Button buttonPartEdit;
        private System.Windows.Forms.Button buttonPartAdd;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewArrivalDoc;
        private System.Windows.Forms.Button buttonArrivalDelete;
        private System.Windows.Forms.Button buttonArrivalEdit;
        private System.Windows.Forms.Button buttonArrivalAdd;
        private System.Windows.Forms.Button buttonArrivalDocDelete;
        private System.Windows.Forms.Button buttonArrivalDocEdit;
        private System.Windows.Forms.Button buttonArrivalDocAdd;
        private System.Windows.Forms.DataGridView dataGridViewArrival;
        private System.Windows.Forms.Button buttonDepartureDelete;
        private System.Windows.Forms.Button buttonDepartureEdit;
        private System.Windows.Forms.Button buttonDepartureAdd;
        private System.Windows.Forms.Button buttonDepartureDocDelete;
        private System.Windows.Forms.Button buttonDepartureDocEdit;
        private System.Windows.Forms.Button buttonDepartureDocAdd;
        private System.Windows.Forms.DataGridView dataGridViewDeparture;
        private System.Windows.Forms.DataGridView dataGridViewDepartureDoc;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

