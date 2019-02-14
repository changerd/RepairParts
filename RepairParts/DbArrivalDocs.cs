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
    public partial class DbArrivalDocs : Form
    {
        public DbArrivalDocs()
        {
            InitializeComponent();
        }
        RepairContext db = new RepairContext();
        private void buttonArrivalDocAddDb_Click(object sender, EventArgs e)
        {
            ArrivalDoc arrivalDoc = new ArrivalDoc
            {
                ArrivalDocName = textBoxArrivalDocName.Text,
                ArrivalDocProvider = textBoxArrivalDocProvider.Text,
                ArrivalDocDate = dateTimePickerArrivalDocDate.Value
            };
            db.ArrivalDocs.Add(arrivalDoc);
            db.SaveChanges();
            this.Close();
            MainForm form = new MainForm();
            form.MainForm_Load(sender, e);
        }

        private void buttonArrivalDocEditDb_Click(object sender, EventArgs e)
        {
            int ardid = Convert.ToInt32(labelId.Text);
            var ard = db.ArrivalDocs.Find(ardid);
            ard.ArrivalDocName = textBoxArrivalDocName.Text;
            ard.ArrivalDocProvider = textBoxArrivalDocProvider.Text;
            ard.ArrivalDocDate = dateTimePickerArrivalDocDate.Value;            
            db.Entry(ard).State = EntityState.Modified;
            db.SaveChanges();
            this.Close();
            MainForm form = new MainForm();
            form.MainForm_Load(sender, e);
        }
    }
}
