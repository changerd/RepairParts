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
    public partial class DbDeparture : Form
    {
        public DbDeparture()
        {
            InitializeComponent();
        }
        RepairContext db = new RepairContext();
        private void DbDeparture_Load(object sender, EventArgs e)
        {
            GetArrivalDoc();
            GetPart();
        }
        private void GetArrivalDoc()
        {
            var query = db.DepartureDocs.ToList();
            comboBoxDepartureDocDb.DataSource = query;
            comboBoxDepartureDocDb.DisplayMember = "DepartureDocName";
            comboBoxDepartureDocDb.ValueMember = "DepartureDocId";
        }
        private void GetPart()
        {
            var query = db.Parts.ToList();
            comboBoxDeparturePartDb.DataSource = query;
            comboBoxDeparturePartDb.DisplayMember = "PartName";
            comboBoxDeparturePartDb.ValueMember = "PartId";
        }

        private void buttonDepartureEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int did = Convert.ToInt32(labelId.Text);
                var d = db.Departures.Find(did);
                d.DepartureDocId = Convert.ToInt32(comboBoxDepartureDocDb.SelectedValue);
                d.PartId = Convert.ToInt32(comboBoxDeparturePartDb.SelectedValue);
                d.DepartureQuantity = Convert.ToInt32(textBoxDeparureQuantityDb.Text);
                db.Entry(d).State = EntityState.Modified;
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

        private void buttonDepartureAddDb_Click(object sender, EventArgs e)
        {            
            try
            {
                Departure departure = new Departure
                {
                    DepartureDocId = Convert.ToInt32(comboBoxDepartureDocDb.SelectedValue),
                    PartId = Convert.ToInt32(comboBoxDeparturePartDb.SelectedValue),
                    DepartureQuantity = Convert.ToInt32(textBoxDeparureQuantityDb.Text),
                };
                db.Departures.Add(departure);
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
