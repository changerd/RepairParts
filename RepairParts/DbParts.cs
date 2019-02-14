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
    public partial class DbParts : Form
    {
        public DbParts()
        {
            InitializeComponent();
        }
        RepairContext db = new RepairContext();
        private void buttonPartAddDb_Click(object sender, EventArgs e)
        {
            Part part = new Part
            {
                PartName = textBoxPartName.Text,
                PartUnit = textBoxPartUnit.Text,
            };
            db.Parts.Add(part);
            db.SaveChanges();
            this.Close();
            MainForm form = new MainForm();
            form.MainForm_Load(sender, e);
        }

        private void buttonPartEditDb_Click(object sender, EventArgs e)
        {
            int partid = Convert.ToInt32(labelId.Text);
            var part = db.Parts.Find(partid);
            part.PartName = textBoxPartName.Text;
            part.PartUnit = textBoxPartUnit.Text;
            db.Entry(part).State = EntityState.Modified;
            db.SaveChanges();
            this.Close();
            MainForm form = new MainForm();
            form.MainForm_Load(sender, e);
        }
        
    }
}
