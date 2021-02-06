using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_007
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void GunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
           // Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 80, 20,Guna.UI.WinForms.VerHorAlign.VerticalRight, );
            //  Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaGradientPanel3, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalLeft);

            //   Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaGradientPanel1, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalLeft);


           
            gunaDataGridView1.Rows.Add(23);

            gunaDataGridView1.Rows[0].Cells[1].Value = (Image)Image.FromFile("barça\\1.jpg");
            gunaDataGridView1.Rows[1].Cells[1].Value = (Image)Image.FromFile("barça\\13.jpg");
            gunaDataGridView1.Rows[2].Cells[1].Value = (Image)Image.FromFile("barça\\26.jpg");
            gunaDataGridView1.Rows[3].Cells[1].Value = (Image)Image.FromFile("barça\\15.jpg");
            gunaDataGridView1.Rows[4].Cells[1].Value = (Image)Image.FromFile("barça\\23.jpg");
            gunaDataGridView1.Rows[5].Cells[1].Value = (Image)Image.FromFile("barça\\3.jpg");
            gunaDataGridView1.Rows[6].Cells[1].Value = (Image)Image.FromFile("barça\\6.jpg");
            gunaDataGridView1.Rows[7].Cells[1].Value = (Image)Image.FromFile("barça\\18.jpg");
            gunaDataGridView1.Rows[8].Cells[1].Value = (Image)Image.FromFile("barça\\24.jpg");
            gunaDataGridView1.Rows[9].Cells[1].Value = (Image)Image.FromFile("barça\\2.jpg");
            gunaDataGridView1.Rows[10].Cells[1].Value = (Image)Image.FromFile("barça\\16.jpg");

            gunaDataGridView1.Rows[11].Cells[1].Value = (Image)Image.FromFile("barça\\5.jpg");
            gunaDataGridView1.Rows[12].Cells[1].Value = (Image)Image.FromFile("barça\\21.jpg");
            gunaDataGridView1.Rows[13].Cells[1].Value = (Image)Image.FromFile("barça\\8.jpg");
            gunaDataGridView1.Rows[14].Cells[1].Value = (Image)Image.FromFile("barça\\20.jpg");
            gunaDataGridView1.Rows[15].Cells[1].Value = (Image)Image.FromFile("barça\\4.jpg");
            gunaDataGridView1.Rows[16].Cells[1].Value = (Image)Image.FromFile("barça\\19.jpg");
            gunaDataGridView1.Rows[17].Cells[1].Value = (Image)Image.FromFile("barça\\22.jpg");


            gunaDataGridView1.Rows[18].Cells[1].Value = (Image)Image.FromFile("barça\\11.jpg");
            gunaDataGridView1.Rows[19].Cells[1].Value = (Image)Image.FromFile("barça\\31.jpg");
            gunaDataGridView1.Rows[20].Cells[1].Value = (Image)Image.FromFile("barça\\10.jpg");
            gunaDataGridView1.Rows[21].Cells[1].Value = (Image)Image.FromFile("barça\\27.jpg");
            gunaDataGridView1.Rows[22].Cells[1].Value = (Image)Image.FromFile("barça\\17.jpg");
            gunaDataGridView1.Rows[23].Cells[1].Value = (Image)Image.FromFile("barça\\9.jpg");



            gunaDataGridView1.Rows[0].Cells[2].Value = "Ter Stegen";
            gunaDataGridView1.Rows[1].Cells[2].Value = "Neto";
            gunaDataGridView1.Rows[2].Cells[2].Value = "Iñaki Peña";
            gunaDataGridView1.Rows[3].Cells[2].Value = "Clément Lenglet";
            gunaDataGridView1.Rows[4].Cells[2].Value = "Samuel Umtiti";
            gunaDataGridView1.Rows[5].Cells[2].Value = "Gerard Piqué";
            gunaDataGridView1.Rows[6].Cells[2].Value = "Jean-Clair Todibo";
            gunaDataGridView1.Rows[7].Cells[2].Value = "Jordi Alba";
            gunaDataGridView1.Rows[8].Cells[2].Value = "Júnior Firpo";
            gunaDataGridView1.Rows[9].Cells[2].Value = "Nélson Semedo";
            gunaDataGridView1.Rows[10].Cells[2].Value = "Moussa Wagué";

            gunaDataGridView1.Rows[11].Cells[2].Value = "Sergio Busquets";
            gunaDataGridView1.Rows[12].Cells[2].Value = "Frenkie de Jong";
            gunaDataGridView1.Rows[13].Cells[2].Value = "Arthur";
            gunaDataGridView1.Rows[14].Cells[2].Value = "Sergi Roberto";
            gunaDataGridView1.Rows[15].Cells[2].Value = "Ivan Rakitic";
            gunaDataGridView1.Rows[16].Cells[2].Value = "Carles Aleñà";
            gunaDataGridView1.Rows[17].Cells[2].Value = "Arturo Vidal";



            gunaDataGridView1.Rows[0].Cells[3].Value = "1";
            gunaDataGridView1.Rows[1].Cells[3].Value = "13";
            gunaDataGridView1.Rows[2].Cells[3].Value = "26";
            gunaDataGridView1.Rows[3].Cells[3].Value = "15";
            gunaDataGridView1.Rows[4].Cells[3].Value = "23";
            gunaDataGridView1.Rows[5].Cells[3].Value = "3";
            gunaDataGridView1.Rows[6].Cells[3].Value = "6";
            gunaDataGridView1.Rows[7].Cells[3].Value = "18";
            gunaDataGridView1.Rows[8].Cells[3].Value = "24";
            gunaDataGridView1.Rows[9].Cells[3].Value = "2";
            gunaDataGridView1.Rows[10].Cells[3].Value = "5";

            gunaDataGridView1.Rows[11].Cells[3].Value = "16";
            gunaDataGridView1.Rows[12].Cells[3].Value = "21";
            gunaDataGridView1.Rows[13].Cells[3].Value = "8";
            gunaDataGridView1.Rows[14].Cells[3].Value = "20";
            gunaDataGridView1.Rows[15].Cells[3].Value = "4";
            gunaDataGridView1.Rows[16].Cells[3].Value = "19";
            gunaDataGridView1.Rows[17].Cells[3].Value = "22";
        }

        private void GunaCirclePictureBox3_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox_p.Image = ((Guna.UI.WinForms.GunaCirclePictureBox)sender).Image;
        }

        private void GunaAdvenceButton8_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro.Location = new Point(gunaAdvenceButton8.Location.X, gunaAdvenceButton8.Location.Y);
            gunaPanel_pro.Visible = true;
        }

        private void GunaAdvenceButton8_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro.Visible = false;
        }

        private void GunaAdvenceButton9_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro.Location = new Point(gunaAdvenceButton9.Location.X, gunaAdvenceButton9.Location.Y);
            gunaPictureBox_show.Image = gunaCirclePictureBox1.Image;
            gunaLabel_show.Text = gunaLabel2.Text;
            gunaLabel46.Text = "1";
            gunaPanel_pro.Visible = true;
        }

        private void GunaAdvenceButton9_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro.Visible = false;

        }
    }
}
