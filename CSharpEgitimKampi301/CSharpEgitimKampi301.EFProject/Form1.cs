using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
        }
        public void Listele()
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }
        private void btnlist_Click(object sender, EventArgs e)
        {
            var values=db.Guide.ToList();
            dataGridView1.DataSource = values;
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(); 
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clear();
            Listele();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue= db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clear();
            Listele();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clear();
            Listele();
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values=db.Guide.Where(x => x.GuideId== id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
