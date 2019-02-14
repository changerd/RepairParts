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
    public partial class DbArrival : Form
    {
        public DbArrival()
        {
            InitializeComponent();
        }
        RepairContext db = new RepairContext();
        private void DbArrival_Load(object sender, EventArgs e)
        {
            GetArrivalDoc();
            GetPart();
        }
        private void GetArrivalDoc()
        {
            var query = db.ArrivalDocs.ToList();
            comboBoxArrivalDocDb.DataSource = query;
            comboBoxArrivalDocDb.DisplayMember = "ArrivalDocName";
            comboBoxArrivalDocDb.ValueMember = "ArrivalDocId";
        }
        private void GetPart()
        {
            var query = db.Parts.ToList();
            comboBoxArrivalPartDb.DataSource = query;
            comboBoxArrivalPartDb.DisplayMember = "PartName";
            comboBoxArrivalPartDb.ValueMember = "PartId";
        }
        private void buttonArrivalAddDb_Click(object sender, EventArgs e)
        {
            try
            {
                decimal arrsum = Convert.ToInt32(textBoxArrivalQuantity.Text) * Convert.ToDecimal(textBoxArrivalCost.Text);
                Arrival arrival = new Arrival
                {
                    ArrivalDocId = Convert.ToInt32(comboBoxArrivalDocDb.SelectedValue),
                    PartId = Convert.ToInt32(comboBoxArrivalPartDb.SelectedValue),
                    ArrivalQuantity = Convert.ToInt32(textBoxArrivalQuantity.Text),
                    ArrivalCost = Convert.ToDecimal(textBoxArrivalCost.Text),
                    ArrivalSum = arrsum,
                };
                db.Arrivals.Add(arrival);
                db.SaveChanges();
                this.Close();
                MainForm form = new MainForm();
                form.MainForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void buttonArrivalEditDb_Click(object sender, EventArgs e)
        {
            try
            {
                int arid = Convert.ToInt32(labelId.Text);
                var ar = db.Arrivals.Find(arid);
                ar.ArrivalDocId = Convert.ToInt32(comboBoxArrivalDocDb.SelectedValue);
                ar.PartId = Convert.ToInt32(comboBoxArrivalPartDb.SelectedValue);
                ar.ArrivalCost = Convert.ToDecimal(textBoxArrivalCost.Text);
                ar.ArrivalQuantity = Convert.ToInt32(textBoxArrivalQuantity.Text);
                ar.ArrivalSum = ar.ArrivalCost * ar.ArrivalQuantity;
                db.Entry(ar).State = EntityState.Modified;
                db.SaveChanges();
                this.Close();
                MainForm form = new MainForm();
                form.MainForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }
    }   
}