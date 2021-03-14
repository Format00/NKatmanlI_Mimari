using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Layer;
using Data_Acces_Layer;
using Logic_Layer;

namespace NKatmanlI_Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<Entity_Personel> PerList = Logic_Layer.Logic_Layer.LLPersonelListesi();
            dataGridView1.DataSource = PerList;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Entity_Personel ent = new Entity_Personel();

            ent.Ad = TxtAD.Text;
            ent.Soyad = TxtSOYAD.Text;
            ent.Sehir = TxtSEHİR.Text;
            ent.Gorev = TxtGOREV.Text;
            ent.Maas = int.Parse(TxtMAAS.Text);

            Logic_Layer.Logic_Layer.LLPersonelEkle(ent);

            MessageBox.Show("Personel Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Entity_Personel ent = new Entity_Personel();

            ent.Id = int.Parse(TxtID.Text);

            Logic_Layer.Logic_Layer.LLPersonelSil(ent);

            MessageBox.Show("Personel Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Entity_Personel ent = new Entity_Personel();

            ent.Id = int.Parse(TxtID.Text);
            ent.Ad = TxtAD.Text;
            ent.Soyad = TxtSOYAD.Text;
            ent.Sehir = TxtSEHİR.Text;
            ent.Gorev = TxtGOREV.Text;
            ent.Maas = int.Parse(TxtMAAS.Text);

            Logic_Layer.Logic_Layer.LLPersonelGüncelle(ent);

            MessageBox.Show("Personel Güncellendi");
        }
    }
}
