using RepairParts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairParts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
        }
        RepairContext db = new RepairContext();
        private void CreateTablePart()
        {
            try
            {
                DataTable tableofParts = new DataTable();
                DataColumn PartIdColumn = new DataColumn("Номер запчати", typeof(int));
                DataColumn PartNameColumn = new DataColumn("Наименование детали", typeof(string));
                DataColumn PartUnitColumn = new DataColumn("Еденица измерения", typeof(string));
                tableofParts.Columns.AddRange(new DataColumn[]
                {
                PartIdColumn,
                PartNameColumn,
                PartUnitColumn
                });
                using (RepairContext context = new RepairContext())
                {
                    var query = context.Parts.ToList();
                    int i = 0;
                    foreach (var p in query)
                    {
                        DataRow newRow = tableofParts.NewRow();
                        newRow["Номер запчати"] = p.PartId;
                        newRow["Наименование детали"] = p.PartName;
                        newRow["Еденица измерения"] = p.PartUnit;
                        tableofParts.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewParts.DataSource = tableofParts;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void CreateTableArrivalDoc()
        {
            try
            {
                DataTable tableofArrivalDoc = new DataTable();
                DataColumn ArrivalDocIdColumn = new DataColumn("Номер документа", typeof(int));
                DataColumn ArrivalDocNameColumn = new DataColumn("Наименование документа", typeof(string));
                DataColumn ArrivalDocProviderColumn = new DataColumn("Поставщик", typeof(string));
                DataColumn ArrivalDocDateColumn = new DataColumn("Дата", typeof(DateTime));
                tableofArrivalDoc.Columns.AddRange(new DataColumn[]
                {
                    ArrivalDocIdColumn,
                    ArrivalDocNameColumn,
                    ArrivalDocProviderColumn,
                    ArrivalDocDateColumn
                });
                using (RepairContext context = new RepairContext())
                {
                    var query = context.ArrivalDocs.ToList();
                    int i = 0;
                    foreach (var a in query)
                    {
                        DataRow newRow = tableofArrivalDoc.NewRow();
                        newRow["Номер документа"] = a.ArrivalDocId;
                        newRow["Наименование документа"] = a.ArrivalDocName;
                        newRow["Поставщик"] = a.ArrivalDocProvider;
                        newRow["Дата"] = a.ArrivalDocDate;
                        tableofArrivalDoc.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewArrivalDoc.DataSource = tableofArrivalDoc;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void CreateTableArrival()
        {
            try
            {
                DataTable tableofArrival = new DataTable();
                DataColumn ArrivalIdColumn = new DataColumn("Номер поступления", typeof(int));
                DataColumn ArrivalPartNameColumn = new DataColumn("Наименование запчасти", typeof(string));
                DataColumn ArrivalDocNameColumn = new DataColumn("Наименование документа", typeof(string));
                DataColumn ArrivalQuantityColumn = new DataColumn("Количество", typeof(int));
                DataColumn ArrivalCostColumn = new DataColumn("Цена", typeof(decimal));
                DataColumn ArrivalSumColumn = new DataColumn("Сумма", typeof(decimal));
                tableofArrival.Columns.AddRange(new DataColumn[]
                {
                    ArrivalIdColumn,
                    ArrivalPartNameColumn,
                    ArrivalDocNameColumn,
                    ArrivalQuantityColumn,
                    ArrivalCostColumn,
                    ArrivalSumColumn
                });
                using (RepairContext context = new RepairContext())
                {
                    var query = context.Arrivals.Include(c => c.Part).Include(a => a.ArrivalDoc).ToList();
                    int i = 0;
                    foreach (var a in query)
                    {
                        DataRow newRow = tableofArrival.NewRow();
                        newRow["Номер поступления"] = a.ArrivalId;
                        newRow["Наименование запчасти"] = a.Part.PartName;
                        newRow["Наименование документа"] = a.ArrivalDoc.ArrivalDocName;
                        newRow["Количество"] = a.ArrivalQuantity;
                        newRow["Цена"] = a.ArrivalCost;
                        newRow["Сумма"] = a.ArrivalSum;
                        tableofArrival.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewArrival.DataSource = tableofArrival;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void CreateTableDeparturelDoc()
        {
            try
            {
                DataTable tableofDepartureDoc = new DataTable();
                DataColumn DepartureDocIdColumn = new DataColumn("Номер документа", typeof(int));
                DataColumn DepartureDocNameColumn = new DataColumn("Наименование документа", typeof(string));
                DataColumn DepartureDocSenderColumn = new DataColumn("Отправитель", typeof(string));
                DataColumn DepartureDocRecipientColumn = new DataColumn("Получатель", typeof(string));
                DataColumn DepartureDocDateColumn = new DataColumn("Дата", typeof(DateTime));
                tableofDepartureDoc.Columns.AddRange(new DataColumn[]
                {
                    DepartureDocIdColumn,
                    DepartureDocNameColumn,
                    DepartureDocSenderColumn,
                    DepartureDocRecipientColumn,
                    DepartureDocDateColumn
                });
                using (RepairContext context = new RepairContext())
                {
                    var query = context.DepartureDocs.ToList();
                    int i = 0;
                    foreach (var d in query)
                    {
                        DataRow newRow = tableofDepartureDoc.NewRow();
                        newRow["Номер документа"] = d.DepartureDocId;
                        newRow["Наименование документа"] = d.DepartureDocName;
                        newRow["Отправитель"] = d.DepartureDocSender;
                        newRow["Получатель"] = d.DepartureDocRecipient;
                        newRow["Дата"] = d.DepartureDocDate;
                        tableofDepartureDoc.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewDepartureDoc.DataSource = tableofDepartureDoc;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void CreateTableDeparture()
        {
            try
            {
                DataTable tableofDeparture = new DataTable();
                DataColumn DepartureIdColumn = new DataColumn("Номер списания", typeof(int));
                DataColumn DeparturePartNameColumn = new DataColumn("Наименование запчасти", typeof(string));
                DataColumn DepartureDocNameColumn = new DataColumn("Наименование документа", typeof(string));
                DataColumn DepartureQuantityColumn = new DataColumn("Количество", typeof(int));                
                tableofDeparture.Columns.AddRange(new DataColumn[]
                {
                    DepartureIdColumn,
                    DeparturePartNameColumn,
                    DepartureDocNameColumn,
                    DepartureQuantityColumn,
                });
                using (RepairContext context = new RepairContext())
                {
                    var query = context.Departures.Include(c => c.Part).Include(a => a.DepartureDoc).ToList();
                    int i = 0;
                    foreach (var d in query)
                    {
                        DataRow newRow = tableofDeparture.NewRow();
                        newRow["Номер списания"] = d.DepartureId;
                        newRow["Наименование запчасти"] = d.Part.PartName;
                        newRow["Наименование документа"] = d.DepartureDoc.DepartureDocName;
                        newRow["Количество"] = d.DepartureQuantity;                        
                        tableofDeparture.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewDeparture.DataSource = tableofDeparture;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (RepairContext db = new RepairContext())
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    CreateTablePart();
                }
                if (tabControl1.SelectedIndex == 1)
                {
                    CreateTableArrival();
                    CreateTableArrivalDoc();
                }
                if (tabControl1.SelectedIndex == 2)
                {
                    CreateTableDeparture();
                    CreateTableDeparturelDoc();
                }
            }
        }

        private void buttonPartAdd_Click(object sender, EventArgs e)
        {
            DbParts form = new DbParts();
            form.buttonPartAddDb.Visible = true;
            form.Text = "Добавление запчасти";
            form.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void buttonPartEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DbParts form = new DbParts();
                form.buttonPartEditDb.Visible = true;
                int partid = Convert.ToInt32(dataGridViewParts.SelectedCells[0].Value);
                var part = db.Parts.Find(partid);
                form.textBoxPartName.Text = part.PartName;
                form.textBoxPartUnit.Text = part.PartUnit;
                form.labelId.Text = part.PartId.ToString();
                form.Text = "Редактирование запчасти";
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }

        }

        private void buttonPartDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RepairContext db = new RepairContext();
                int partid = Convert.ToInt32(dataGridViewParts.SelectedCells[0].Value);
                var part = db.Parts.Find(partid);
                db.Parts.Remove(part);
                db.SaveChanges();
                tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonArrivalDocAdd_Click(object sender, EventArgs e)
        {
            DbArrivalDocs form = new DbArrivalDocs();
            form.buttonArrivalDocAddDb.Visible = true;
            form.Text = "Добавление документа поступления";
            form.Show();

        }

        private void buttonArrivalDocEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DbArrivalDocs form = new DbArrivalDocs();
                form.buttonArrivalDocEditDb.Visible = true;
                form.Text = "Редактирование документа поступления";
                int ardid = Convert.ToInt32(dataGridViewArrivalDoc.SelectedCells[0].Value);
                var ard = db.ArrivalDocs.Find(ardid);
                form.textBoxArrivalDocName.Text = ard.ArrivalDocName;
                form.textBoxArrivalDocProvider.Text = ard.ArrivalDocProvider;
                form.dateTimePickerArrivalDocDate.Value = ard.ArrivalDocDate;
                form.labelId.Text = ard.ArrivalDocId.ToString();
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonArrivalDocDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RepairContext db = new RepairContext();
                int ardid = Convert.ToInt32(dataGridViewArrivalDoc.SelectedCells[0].Value);
                var ard = db.ArrivalDocs.Find(ardid);
                db.ArrivalDocs.Remove(ard);
                db.SaveChanges();
                tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonArrivalAdd_Click(object sender, EventArgs e)
        {
            DbArrival form = new DbArrival();
            form.Text = "Добавление поступления";
            form.buttonArrivalAddDb.Visible = true;
            form.Show();
        }

        private void buttonArrivalEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DbArrival form = new DbArrival();
                form.buttonArrivalEditDb.Visible = true;
                form.Text = "Редактирования поступления";
                int arid = Convert.ToInt32(dataGridViewArrival.SelectedCells[0].Value);
                var ar = db.Arrivals.Find(arid);
                form.textBoxArrivalCost.Text = ar.ArrivalCost.ToString();
                form.textBoxArrivalQuantity.Text = ar.ArrivalQuantity.ToString();
                form.labelId.Text = ar.ArrivalId.ToString();
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonArrivalDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RepairContext db = new RepairContext();
                int arid = Convert.ToInt32(dataGridViewArrival.SelectedCells[0].Value);
                var ar = db.Arrivals.Find(arid);
                db.Arrivals.Remove(ar);
                db.SaveChanges();
                tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonDepartureDocAdd_Click(object sender, EventArgs e)
        {
            DbDepartureDoc form = new DbDepartureDoc();
            form.Text = "Добавление документа списания";
            form.buttonDepartureDocAddDb.Visible = true;
            form.Show();            
        }

        private void buttonDepartureDocEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DbDepartureDoc form = new DbDepartureDoc();
                form.Text = "Редактирование документа списания";
                form.buttonDepartureDocEditDb.Visible = true;
                int ddid = Convert.ToInt32(dataGridViewDepartureDoc.SelectedCells[0].Value);
                var dd = db.DepartureDocs.Find(ddid);
                form.textBoxDepartureDocNameDb.Text = dd.DepartureDocName;
                form.textBoxDepartureDocSenderDb.Text = dd.DepartureDocSender;
                form.textBoxDepartureDocRecipentDb.Text = dd.DepartureDocRecipient;
                form.dateTimePickerDepartureDocDb.Value = dd.DepartureDocDate;
                form.labelId.Text = dd.DepartureDocId.ToString();
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonDepartureDocDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RepairContext db = new RepairContext();
                int ddid = Convert.ToInt32(dataGridViewDepartureDoc.SelectedCells[0].Value);
                var dd = db.DepartureDocs.Find(ddid);
                db.DepartureDocs.Remove(dd);
                db.SaveChanges();
                tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonDepartureAdd_Click(object sender, EventArgs e)
        {
            DbDeparture form = new DbDeparture();
            form.Text = "Добавление поступления";
            form.buttonDepartureAddDb.Visible = true;
            form.Show();            
        }

        private void buttonDepartureEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DbDeparture form = new DbDeparture();
                form.Text = "Редактирование поступления";
                form.buttonDepartureEdit.Visible = true;
                int did = Convert.ToInt32(dataGridViewDeparture.SelectedCells[0].Value);
                var d = db.Departures.Find(did);
                form.textBoxDeparureQuantityDb.Text = d.DepartureQuantity.ToString();
                form.labelId.Text = d.DepartureId.ToString();
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonDepartureDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RepairContext db = new RepairContext();
                int did = Convert.ToInt32(dataGridViewDeparture.SelectedCells[0].Value);
                var d = db.Departures.Find(did);
                db.Departures.Remove(d);
                db.SaveChanges();
                tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }
    }
}
