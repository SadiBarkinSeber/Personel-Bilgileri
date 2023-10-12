using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personel_Bilgileri
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dtpIseGirisTarihi.MaxDate = DateTime.Today;
            dtpDogumTarihi.MaxDate = DateTime.Today;
            dtpIseGirisTarihi.MinDate = dtpDogumTarihi.Value;
        }

        List<Kisi> People = new List<Kisi>();

        string dosyaYolu;

        #region Resim Seç Butonu İşlemleri
        public void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg (.jpg) | *.jpg | Png (.png) | *.png";
            ofd.ShowDialog();
            
            dosyaYolu = ofd.FileName;
            pBResim.ImageLocation = dosyaYolu;
        }
        #endregion 

        #region Kaydet Butonu İşlemleri
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi person = new Kisi();
            person.PersonelID = textBox1.Text;
            person.FirstName = textBox2.Text;
            person.LastName = textBox3.Text;
            person.DogumTarihi = dtpDogumTarihi.Value;
            person.Telephone = mtbTelefon.Text;
            person.Email = textBox6.Text;
            person.IseGirisTarihi = dtpIseGirisTarihi.Value;
            person.Adress = txtAdres.Text;
            person.DosyaYolu = dosyaYolu;

            bool durum = HataDurumlari(person.PersonelID, person.DogumTarihi, person.Email, person.IseGirisTarihi);

            if(durum == true)
            {

            }
            else
            {
                People.Add(person);
                ListViewiDoldur();
                Sifirla();
            }
        }
        #endregion

        #region ListViewiDoldur()
        private void ListViewiDoldur()
        {
            
            lVList.Items.Clear();
            foreach (Kisi person in People)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = person.PersonelID;
                lvi.SubItems.Add(person.FirstName);
                lvi.SubItems.Add(person.LastName);
                lvi.SubItems.Add(person.DogumTarihi.ToString("yyy-MM-dd"));
                lvi.SubItems.Add(person.Telephone);
                lvi.SubItems.Add(person.Email);
                lvi.SubItems.Add(person.IseGirisTarihi.ToString("yyy-MM-dd"));
                lvi.SubItems.Add(person.Adress);
                lvi.SubItems.Add(person.DosyaYolu);

                lVList.Items.Add(lvi);
            }
        }
        #endregion

        #region regionbtnGuncelle_Click()
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ListViewItem selectedRow = lVList.SelectedItems[0];
            int selectedIndex = lVList.Items.IndexOf(selectedRow);

            // Verileri al
            string ID = textBox1.Text;
            string Ad = textBox2.Text;
            string Soyad = textBox3.Text;
            DateTime DogumTarihi = dtpDogumTarihi.Value;
            string Telefon = mtbTelefon.Text;
            string Email = textBox6.Text;
            DateTime IseGirisTarihi = dtpIseGirisTarihi.Value;
            string Adres = txtAdres.Text;
            string DosyaYolu = dosyaYolu;

            selectedRow.SubItems[0].Text = ID;
            selectedRow.SubItems[1].Text = Ad;
            selectedRow.SubItems[2].Text = Soyad;
            selectedRow.SubItems[3].Text = DogumTarihi.ToString("yyyy-MM-dd");
            selectedRow.SubItems[4].Text = Telefon;
            selectedRow.SubItems[5].Text = Email;
            selectedRow.SubItems[6].Text = IseGirisTarihi.ToString("yyyy-MM-dd");
            selectedRow.SubItems[7].Text = Adres;
            selectedRow.SubItems[8].Text = DosyaYolu.ToString();
        }
        #endregion

        #region btnSil_Click()
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lVList.SelectedItems.Count > 0)
            {
                ListViewItem selectionRow = lVList.SelectedItems[0];
                lVList.Items.Remove(selectionRow);
            }
        }
        #endregion

        #region Buton Durumları
        private void lVList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVList.FocusedItem.Index != -1)
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            else
            {
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
            }
            //Listte seçim yaptıktan sonra
            if (lVList.SelectedItems.Count == 1)
            {
                ListViewItem selectedRow = lVList.SelectedItems[0];

                textBox1.Text = selectedRow.SubItems[0].Text;
                textBox2.Text = selectedRow.SubItems[1].Text;
                textBox3.Text = selectedRow.SubItems[2].Text;
                dtpDogumTarihi.Value = DateTime.ParseExact(selectedRow.SubItems[3].Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                mtbTelefon.Text = selectedRow.SubItems[4].Text;
                textBox6.Text = selectedRow.SubItems[5].Text;
                dtpIseGirisTarihi.Value = DateTime.ParseExact(selectedRow.SubItems[6].Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                txtAdres.Text = selectedRow.SubItems[7].Text;
                string resimDosyaYolu = selectedRow.SubItems[8].Text;

                btnKaydet.Enabled = false;

                textBox1.BackColor = Color.LightSteelBlue;
                textBox2.BackColor = Color.LightSteelBlue;
                textBox3.BackColor = Color.LightSteelBlue;
                dtpDogumTarihi.CalendarTitleBackColor = Color.LightSteelBlue;
                mtbTelefon.BackColor = Color.LightSteelBlue;
                textBox6.BackColor = Color.LightSteelBlue;
                dtpIseGirisTarihi.CalendarTitleBackColor = Color.LightSteelBlue;
                txtAdres.BackColor = Color.LightSteelBlue;
                pBResim.ImageLocation = resimDosyaYolu;
            }
            else
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                dtpDogumTarihi.Value = DateTime.Today;
                mtbTelefon.Text = string.Empty;
                textBox6.Text = string.Empty;
                dtpIseGirisTarihi.Value = DateTime.Today;
                txtAdres.Text = string.Empty;
                dosyaYolu = string.Empty;
                pBResim.Image = null;

                btnKaydet.Enabled = true;
                btnResimSec.Enabled = true;

                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                dtpDogumTarihi.CalendarTitleBackColor = Color.White;
                mtbTelefon.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                dtpIseGirisTarihi.CalendarTitleBackColor = Color.White;
                txtAdres.BackColor = Color.White;
            }
        }
        #endregion

        #region Hata Durum Metotları
        public bool TarihKontrol()
        {
            if (dtpIseGirisTarihi.Value.Year < dtpDogumTarihi.Value.Year)
            {
                MessageBox.Show("İşe giriş tarihi doğum tarihinden önce olamaz");
                return true;
            }
            else return false;
        }

        public bool IdUzunlukKontrol(string ID)
        {
            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Personel ID 5 karakterden kısa olamaz.");
                return true;
            }
            else return false;
        }
        private bool YasKonrol(DateTime DogumTarihi)
        {
            int yas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
            if (yas < 18)
            {
                MessageBox.Show("Yaşınız 18'den küçük olamaz.");
                return true;
            }
            else return false;
        }
        private bool MailKontrol(string Email)
        {
            if (!textBox6.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("E-posta adresi @gmail.com ile bitmelidir.");
                return true;
            }
            else return false;
        }
        private bool IseGirisKontrol(DateTime IseGirisTarihi)
        {
            if (dtpIseGirisTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("İşe giriş tarihi gelecek bir tarihte olamaz.");
                return true;
            }
            else return false;
        }
        #endregion

        #region HataDurumlari()
        private bool HataDurumlari(string ID, DateTime DogumTarihi, string Email, DateTime IseGirisTarihi)
        {
            bool IdDurumu = IdUzunlukKontrol(ID);
            bool YasDurumu = YasKonrol(DogumTarihi);
            bool MaiDurumu = MailKontrol(Email);
            bool IseBaslangicDurumu = IseGirisKontrol(IseGirisTarihi);
            bool TarihiKontrol = TarihKontrol();

            if (IdDurumu || YasDurumu || MaiDurumu || IseBaslangicDurumu || TarihiKontrol) 
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region İşe giriş tarihi gelecek bir tarihte olamaz
        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseGirisTarihi.MinDate = dtpDogumTarihi.Value;
        }
        #endregion

        #region Sifirla()
        private void Sifirla()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            dtpDogumTarihi.Value = DateTime.Today;
            mtbTelefon.Text = string.Empty;
            textBox6.Text = string.Empty;
            dtpIseGirisTarihi.Value = DateTime.Today;
            txtAdres.Text = string.Empty;
            dosyaYolu = string.Empty;
            pBResim.ImageLocation = null;
        }
        #endregion

        #region Textboxların Düzeni
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(textBox1.Text, out result))
            {
                MessageBox.Show("Lütfen sadece sayısal değer giriniz.");
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !textBox2.Text.All(char.IsLetter))
            {
                MessageBox.Show("Lütfen yalnızca harf karakterleri giriniz.");
                textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !textBox3.Text.All(char.IsLetter))
            {
                MessageBox.Show("Lütfen yalnızca harf karakterleri giriniz.");
                textBox3.Clear();
            }
        }
        #endregion
    }
}
