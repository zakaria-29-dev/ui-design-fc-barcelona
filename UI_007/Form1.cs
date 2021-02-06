using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna; 

namespace UI_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panel, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaAdvenceButton1, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaAdvenceButton2, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaAdvenceButton3, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaAdvenceButton4, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaAdvenceButton5, Color.Black, 80, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight);

            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 40, 15, Guna.UI.WinForms.VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel1, Color.Black, 40, 15, Guna.UI.WinForms.VerHorAlign.VerticalLeft);

            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(gunaPanel2, Color.Black, 40, 15, Guna.UI.WinForms.VerHorAlign.VerticalLeft);


        }
    }
}
