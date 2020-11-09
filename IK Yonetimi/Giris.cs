﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public partial class Giris : Form
    {
        public static bool girisYap = false;
        public Giris()
        {
            InitializeComponent();
        }

        private void uyeolLbl_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            Başvurular.PreorderGiris(adTxt.Text, telTxt.Text);
            if (girisYap)
            {
                MessageBox.Show("Giriş Başarılı!");
                Başvurular.PreorderBilgiCek(Başvurular.kok, adTxt.Text);
                Hesabım hesabim = new Hesabım();
                hesabim.Show();
                girisYap = false;
            }
            else
            {
                MessageBox.Show("Giriş Başarısız! Girdiğiniz bilgileri lütfen kontrol edin");
            }
            
        }
    }
}
