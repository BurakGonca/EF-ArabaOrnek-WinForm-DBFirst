using _7mart2024.Entitites;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace _7mart2024
{
    public partial class Form1 : Form
    {
        ArabaDBContext dB = new ArabaDBContext();
        Araba secilenAraba;

        public Form1()
        {
            InitializeComponent();

        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.Marka = marka_textbox.Text;
            araba.Model = model_textbox.Text;
            araba.PlakaID = ((Plaka)(comboBox_Plaka.SelectedItem)).PlakaID;
            araba.KisiID = ((Kisi)(comboBox_Kisi.SelectedItem)).ID;

            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Arabayi eklemek istediðinizden emin misiniz?", "Ekle", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dB.Arabalar.Add(araba);
                dB.SaveChanges();
                MessageBox.Show("Arac Basariyla Eklenmistir!");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = araba;
                dataGridView1.DataSource = dB.Arabalar.ToList();
            }



        }

        private void listele_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dB.Arabalar.ToList();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null)
            {

                var silinecekAraba = dB.Arabalar.FirstOrDefault(a => a.Marka == secilenAraba.Marka);
                dB.Arabalar.Remove(silinecekAraba);
                dB.SaveChanges();
                MessageBox.Show("Araba silinmistir");
                dataGridView1.DataSource = dB.Arabalar.ToList();

            }
            else
                MessageBox.Show("Secili Araba Yok!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAraba = (Araba)dataGridView1.SelectedRows[0].DataBoundItem;

            marka_textbox.Text = secilenAraba.Marka;
            model_textbox.Text = secilenAraba.Model;

            comboBox_Plaka.Text = secilenAraba.Plaka.Numara;
            comboBox_Kisi.Text = secilenAraba.Kisi.Adi + " " + secilenAraba.Kisi.Soyadi;



        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null)
            {

                var guncellenecekAraba = dB.Arabalar.FirstOrDefault(a => a.Marka == secilenAraba.Marka);
                guncellenecekAraba.Marka = marka_textbox.Text;
                guncellenecekAraba.Model = model_textbox.Text;
                guncellenecekAraba.Kisi = (Kisi)(comboBox_Kisi.SelectedItem);
                guncellenecekAraba.Plaka = (Plaka)(comboBox_Plaka.SelectedItem);

                dB.Arabalar.Update(guncellenecekAraba);
                dB.SaveChanges();
                MessageBox.Show("Araba guncellenmistir");
                dataGridView1.DataSource = dB.Arabalar.ToList();

            }
            else
                MessageBox.Show("Secili Araba Yok!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox_Kisi.DataSource = dB.Kisiler.ToList();
            comboBox_Plaka.DataSource = dB.Plakalar.ToList();
            comboBox_Muhendis.DataSource = dB.Muhendisler.ToList();

            //dataGridView1.DataSource = dB.Arabalar.ToList();



        }

        private void muhEkle_btn_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null)
            {
                var seciliMuhendis = (Muhendis)(comboBox_Muhendis.SelectedItem);
                if (secilenAraba.Muhendisler == null)
                    secilenAraba.Muhendisler = new List<Muhendis>(); 
                secilenAraba.Muhendisler.Add(seciliMuhendis);
                dB.SaveChanges();
                MessageBox.Show("Mühendis araca baþarýyla eklendi.");
                dataGridView1.DataSource = dB.Arabalar.ToList();
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin.");
            }

        }

        private void comboBox_Muhendis_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var seciliMuh = (Muhendis)(comboBox_Muhendis.SelectedItem);

            //dataGridView2.DataSource = seciliMuh.Arabalar.ToList() ;

        }

        private void muhSil_btn_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null && dataGridView1.CurrentRow != null)
            {
                var seciliMuhendis = ((Muhendis)comboBox_Muhendis.SelectedItem);
                secilenAraba.Muhendisler.Remove(seciliMuhendis);
                dB.SaveChanges();
                MessageBox.Show("Mühendis araçtan baþarýyla çýkarýldý.");
                dataGridView1.DataSource = dB.Arabalar.ToList();
            }
            else
            {
                MessageBox.Show("Lütfen bir araç ve mühendis seçin.");
            }
        }

        private void muhListele_btn_Click(object sender, EventArgs e)
        {

            var seciliMuhendis = ((Muhendis)comboBox_Muhendis.SelectedItem);


            //dataGridView1.DataSource = seciliMuhendis.Arabalar.ToList();

            comboBox_Muhendis.DataSource = dB.Muhendisler.Include(m => m.Arabalar).ToList();

            dataGridView1.DataSource = seciliMuhendis.Arabalar.ToList();





        }





    }
}
