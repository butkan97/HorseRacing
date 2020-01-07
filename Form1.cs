using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace AtYarisi1
{

    public partial class Form1 : Form
    {

        public static Random r = new Random();

        // List<string> atlarım = new List<string>(6) {"Hecarim","Bolt Pilot","Şahbatur","Gülbatur","Nazlıcan","Arap Atı" };

        List<string> atListesi = new List<string>(6);

        // List<string> isimListesi = new List<string>();

        List<List<string>> sinifListesi = new List<List<string>>();

        string[] AtDizi = new string[] { "Hecarim", "Bolt Pilot", "Şahbatur", "Gülbatur", "Nazlıcan", "Arap Atı" };
        string[] Adlar = new string[] { "Butkan", "Kadir", "Özgür", "Nurullah","Harun","Büşra","Tayfun","Yiğit","Emirhan"
        ,"Eda","Emre","İlker","Oguzhan","Ayberk"};
        int yaris = 0;

        List<string> genelIsim = new List<string>();

        public Form1()
        {
            InitializeComponent();
            txt_Ad.Text = "";
            txt_Para.Text = "";
        }

        double paraa;
        // int at1SolaUz;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kum_Click(object sender, EventArgs e)
        {

            this.BackgroundImage = Properties.Resources.kum;
        }

        private void btn_cim_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.çim;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\";
            ses.SoundLocation = dizin;
            ses.Play();

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 200;

            int birinciAtGenislik = pictureBox1.Width;

            pictureBox1.Left += r.Next(1, 20);

            if (birinciAtGenislik + pictureBox1.Left >= panel1.Left)
            {
                atListesi.Add("Hecarim");
                listBox1.Items.Add("Hecarim");
                timer1.Enabled = false;
                yaris = 1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btn_BahisYap.Enabled = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel_Kazananlar.Visible = false;
            panel4.Visible = false;
            panel_Kaybedenler.Visible = false;

            comboBox1.Left = 0;
            comboBox2.Left = 0;
            comboBox3.Left = 0;
            comboBox4.Left = 0;
            comboBox5.Left = 0;
            comboBox6.Left = 0;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Interval = 200;
            int ikinciAtGenislik = pictureBox2.Width;
            pictureBox2.Left += r.Next(1, 20);

            if (ikinciAtGenislik + pictureBox2.Left >= panel1.Left)
            {
                atListesi.Add("Bolt Pilot");
                listBox1.Items.Add("Bolt Pilot");
                timer2.Enabled = false;

            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 200;
            int ücüncüAtGenislik = pictureBox3.Width;
            pictureBox3.Left += r.Next(1, 20);

            if (ücüncüAtGenislik + pictureBox3.Left >= panel1.Left)
            {
                atListesi.Add("Şahbatur");
                listBox1.Items.Add("Şahbatur");
                timer3.Enabled = false;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 200;
            int dördüncüAtGenislik = pictureBox4.Width;
            pictureBox4.Left += r.Next(1, 20);
            if (dördüncüAtGenislik + pictureBox4.Left >= panel1.Left)
            {
                atListesi.Add("Gülbatur");
                listBox1.Items.Add("Gülbatur");
                timer4.Enabled = false;

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Interval = 200;
            int besinciAtGenislik = pictureBox5.Width;
            pictureBox5.Left += r.Next(1, 20);

            if (besinciAtGenislik + pictureBox5.Left >= panel1.Left)
            {
                atListesi.Add("Nazlıcan");
                listBox1.Items.Add("Nazlıcan");
                timer5.Enabled = false;

            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Interval = 200;
            int altinciAtGenislik = pictureBox6.Width;
            pictureBox6.Left += r.Next(1, 20);

            if (altinciAtGenislik + pictureBox6.Left >= panel1.Left)
            {
                atListesi.Add("Arap Atı");
                listBox1.Items.Add("Arap Atı");
                timer6.Enabled = false;

            }
        }



        private void kumPistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

        }

        private void çimPistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void btn_KuponKpt_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btn_BahisYap_Click(object sender, EventArgs e)
        {


            List<string> isimListesi = new List<string>();
            string ad, birinciAyak, ikinciAyak, ücüncüAyak, dördüncüAyak, besinciAyak, altinciAyak, para;

            double ganyan;



            para = txt_Para.Text;

            ganyan = paraa * 1.5;


            ad = txt_Ad.Text;





            birinciAyak = comboBox1.SelectedItem.ToString();
            ikinciAyak = comboBox2.SelectedItem.ToString();
            ücüncüAyak = comboBox3.SelectedItem.ToString();
            dördüncüAyak = comboBox4.SelectedItem.ToString();
            besinciAyak = comboBox5.SelectedItem.ToString();
            altinciAyak = comboBox6.SelectedItem.ToString();




            isimListesi.Add(ad);

            isimListesi.Add(birinciAyak);
            isimListesi.Add(ikinciAyak);
            isimListesi.Add(ücüncüAyak);
            isimListesi.Add(dördüncüAyak);
            isimListesi.Add(besinciAyak);
            isimListesi.Add(altinciAyak);

            isimListesi.Add(ganyan.ToString());

            sinifListesi.Add(isimListesi);





            dataGridView1.Rows.Add(ad, birinciAyak, ikinciAyak, ücüncüAyak, dördüncüAyak, besinciAyak, altinciAyak, ganyan.ToString());

            MessageBox.Show("Kuponunuz Oluşturuldu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }




        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void btn_KuponlariKpt_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Para_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(txt_Para.Text, out paraa))
            {
                paraa = Convert.ToDouble(txt_Para.Text);

            }
            else
                MessageBox.Show("Yanlış değer Girdiniz..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


        }

        private void çokluKuponYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;



        }

        private void lİstelerToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void kazananlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int i, k = 1;



            if (yaris == 1)
            {

                foreach (var item in sinifListesi)
                {

                    for (i = 0; i < 6; i++)
                    {

                        if (item[k].ToString() == atListesi[i])
                        {

                            k++;

                            if (i == 5)
                            {
                                dataGridView2.Rows.Add(item[0].ToString(), item[1].ToString(), item[2], item[3].ToString(), item[4].ToString(),
                               item[5].ToString(), item[6].ToString(), item[7].ToString());
                            }



                        }
                        else
                        {

                            k = 1;
                            break;


                        }


                    }


                }

                panel_Kazananlar.Visible = true;

            }
            else
                MessageBox.Show("Yarış Daha Bitmedi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_KazananKpt_Click(object sender, EventArgs e)
        {
            panel_Kazananlar.Visible = false;
        }

        public enum Atlar
        {
            Hecarim, BoltPilot, Şahbatur, Gülbatur, Nazlıcan, ArapAtı

        }

        private void btn_CokluBahKpt_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btn_CokluOyna_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_Adet.Text))
            {
                string ad, birinciAyak, ikinciAyak, ücüncüAyak, dördüncüAyak, besinciAyak, altinciAyak;

                double ganyan;
                int para;


                int adet = Convert.ToInt32(txt_Adet.Text);



                for (int i = 0; i < adet; i++)
                {
                    List<string> isimListesi = new List<string>();
                    List<string> atlarım = new List<string>(6) { "Hecarim", "Bolt Pilot", "Şahbatur", "Gülbatur", "Nazlıcan", "Arap Atı" };
                    para = r.Next(0, 500);



                    ad = Adlar[r.Next(0, Adlar.Length)];

                    int rast = r.Next(0, 6);
                    birinciAyak = atlarım[rast];
                    atlarım.Remove(atlarım[rast].ToString());

                    rast = r.Next(0, 5);
                    ikinciAyak = atlarım[rast];
                    atlarım.Remove(atlarım[rast].ToString());

                    rast = r.Next(0, 4);
                    ücüncüAyak = atlarım[rast];
                    atlarım.Remove(atlarım[rast].ToString());

                    rast = r.Next(0, 3);
                    dördüncüAyak = atlarım[rast];
                    atlarım.Remove(atlarım[rast].ToString());

                    rast = r.Next(0, 2);
                    besinciAyak = atlarım[rast];
                    atlarım.Remove(atlarım[rast].ToString());

                    rast = r.Next(0, 1);
                    altinciAyak = atlarım[rast];
                    atlarım.Remove(atlarım[rast].ToString());

                    ganyan = para * 1.5;




                    if (genelIsim.Contains(ad) == false)
                    {

                        genelIsim.Add(ad);
                        isimListesi.Add(ad);

                    }
                    else
                    {
                        ad = ad + r.Next(0, 500).ToString();
                        genelIsim.Add(ad);
                        isimListesi.Add(ad);
                    }


                    isimListesi.Add(birinciAyak);
                    isimListesi.Add(ikinciAyak);
                    isimListesi.Add(ücüncüAyak);
                    isimListesi.Add(dördüncüAyak);
                    isimListesi.Add(besinciAyak);
                    isimListesi.Add(altinciAyak);
                    isimListesi.Add(ganyan.ToString());




                    dataGridView1.Rows.Add(ad, birinciAyak, ikinciAyak, ücüncüAyak, dördüncüAyak, besinciAyak, altinciAyak, ganyan.ToString());

                    sinifListesi.Add(isimListesi);




                }

                MessageBox.Show("Kuponunuz Oluşturuldu");

            }
            else
            {
                MessageBox.Show("Geçerli bir adet Giriniz","Uyaru",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           



        }

        private void tekliKuponYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void tekliKuponYapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void tekliKuponToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tekli_KuponYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btn_KaybedenlerKpt_Click(object sender, EventArgs e)
        {
            panel_Kaybedenler.Visible = false;

        }

        private void kaybedenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int i, k = 1;

            if (yaris == 1)
            {

                foreach (var item in sinifListesi)
                {

                    for (i = 0; i < 6; i++)
                    {

                        if (item[k].ToString() != atListesi[i])
                        {


                            dataGridView3.Rows.Add(item[0].ToString(), item[1].ToString(), item[2], item[3].ToString(), item[4].ToString(),
                                item[5].ToString(), item[6].ToString(), item[7].ToString());
                            k = 1;
                            break;


                        }
                        else
                        {

                            k++;


                        }


                    }


                }

                panel_Kaybedenler.Visible = true;

            }
            else
            {
                MessageBox.Show("Yarış Daha Bitmedi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }









        }

        private void txt_Adet_TextChanged(object sender, EventArgs e)
        {




        }

        private void txt_Adet_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txt_Para_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null &&
                comboBox5.SelectedItem != null && comboBox6.SelectedItem != null && txt_Ad.Text != "" && txt_Para.Text != "")
            {
                btn_BahisYap.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
