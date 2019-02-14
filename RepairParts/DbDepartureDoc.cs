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
    public partial class DbDepartureDoc : Form
    {
        public DbDepartureDoc()
        {
            InitializeComponent();
        }
        RepairContext db = new RepairContext();
        private void buttonDepartureDocAddDb_Click(object sender, EventArgs e)
        {
            DepartureDoc dd = new DepartureDoc
            {
                DepartureDocName = textBoxDepartureDocNameDb.Text,
                DepartureDocSender = textBoxDepartureDocSenderDb.Text,
                DepartureDocRecipient = textBoxDepartureDocRecipentDb.Text,
                DepartureDocDate = dateTimePickerDepartureDocDb.Value,
            };
            db.DepartureDocs.Add(dd);
            db.SaveChanges();
            this.Close();
            MainForm form = new MainForm();
            form.MainForm_Load(sender, e);
        }

        private void buttonDepartureDocEditDb_Click(object sender, EventArgs e)
        {
            int ddid = Convert.ToInt32(labelId.Text);
            var dd = db.DepartureDocs.Find(ddid);
            dd.DepartureDocName = textBoxDepartureDocNameDb.Text;
            dd.DepartureDocSender = textBoxDepartureDocSenderDb.Text;
            dd.DepartureDocRecipient = textBoxDepartureDocRecipentDb.Text;
            dd.DepartureDocDate = dateTimePickerDepartureDocDb.Value;
            db.Entry(dd).State = EntityState.Modified;
            db.SaveChanges();
            this.Close();
            MainForm form = new MainForm();
            form.MainForm_Load(sender, e);
        }
    }
}
