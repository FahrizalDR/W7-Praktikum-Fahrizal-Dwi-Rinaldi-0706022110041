using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7Praktikum
{
    public partial class Form1 : Form
    {
        public string InputHuruf = "";
        public string Menjadi = "";
        public string Hasil = "";
        public string[] IndexHuruf = new string[30];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            InputHuruf = txtBoxInputHuruf.Text;
            Menjadi = txtBoxMenjadi.Text;
            if (txtBoxMenjadi.Text.ToUpper() == "A")
                txtBoxInputHuruf.Text = IndexHuruf[0];
            else if (txtBoxMenjadi.Text.ToUpper() == "B")
                txtBoxInputHuruf.Text = IndexHuruf[1];
            else if (txtBoxMenjadi.Text.ToUpper() == "C")
                txtBoxInputHuruf.Text = IndexHuruf[2];
            else if (txtBoxMenjadi.Text.ToUpper() == "D")
                txtBoxInputHuruf.Text = IndexHuruf[3];
            else if (txtBoxMenjadi.Text.ToUpper() == "E")
                txtBoxInputHuruf.Text = IndexHuruf[4];
            else if (txtBoxMenjadi.Text.ToUpper() == "F")
                txtBoxInputHuruf.Text = IndexHuruf[5];
            else if (txtBoxMenjadi.Text.ToUpper() == "G")
                txtBoxInputHuruf.Text = IndexHuruf[6];
            else if (txtBoxMenjadi.Text.ToUpper() == "H")
                txtBoxInputHuruf.Text = IndexHuruf[7];
            else if (txtBoxMenjadi.Text.ToUpper() == "I")
                txtBoxInputHuruf.Text = IndexHuruf[8];
            else if (txtBoxMenjadi.Text.ToUpper() == "J")
                txtBoxInputHuruf.Text = IndexHuruf[9];
            else if (txtBoxMenjadi.Text.ToUpper() == "K")
                txtBoxInputHuruf.Text = IndexHuruf[10];
            else if (txtBoxMenjadi.Text.ToUpper() == "L")
                txtBoxInputHuruf.Text = IndexHuruf[11];
            else if (txtBoxMenjadi.Text.ToUpper() == "M")
                txtBoxInputHuruf.Text = IndexHuruf[12];
            else if (txtBoxMenjadi.Text.ToUpper() == "N")
                txtBoxInputHuruf.Text = IndexHuruf[13];
            else if (txtBoxMenjadi.Text.ToUpper() == "O")
                txtBoxInputHuruf.Text = IndexHuruf[14];
            else if (txtBoxMenjadi.Text.ToUpper() == "P")
                txtBoxInputHuruf.Text = IndexHuruf[15];
            else if (txtBoxMenjadi.Text.ToUpper() == "Q")
                txtBoxInputHuruf.Text = IndexHuruf[16];
            else if (txtBoxMenjadi.Text.ToUpper() == "R")
                txtBoxInputHuruf.Text = IndexHuruf[17];
            else if (txtBoxMenjadi.Text.ToUpper() == "S")
                txtBoxInputHuruf.Text = IndexHuruf[18];
            else if (txtBoxMenjadi.Text.ToUpper() == "T")
                txtBoxInputHuruf.Text = IndexHuruf[19];
            else if (txtBoxMenjadi.Text.ToUpper() == "U")
                txtBoxInputHuruf.Text = IndexHuruf[20];
            else if (txtBoxMenjadi.Text.ToUpper() == "V")
                txtBoxInputHuruf.Text = IndexHuruf[21];
            else if (txtBoxMenjadi.Text.ToUpper() == "W")
                txtBoxInputHuruf.Text = IndexHuruf[22];
            else if (txtBoxMenjadi.Text.ToUpper() == "X")
                txtBoxInputHuruf.Text = IndexHuruf[23];
            else if (txtBoxMenjadi.Text.ToUpper() == "Y")
                txtBoxInputHuruf.Text = IndexHuruf[24];
            else if (txtBoxMenjadi.Text.ToUpper() == "Z")
                txtBoxInputHuruf.Text = IndexHuruf[25];            

            Hasil = txtBoxInputKalimat.Text.Replace(InputHuruf, Menjadi).ToUpper();
            labelOutput.Text = Hasil;
            txtBoxInputHuruf.Text = "";
            txtBoxMenjadi.Text = "";
            txtBoxInputKalimat.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            IndexHuruf[0] = "A";
            IndexHuruf[1] = "B";
            IndexHuruf[2] = "C";
            IndexHuruf[3] = "D";
            IndexHuruf[4] = "E";
            IndexHuruf[5] = "F";
            IndexHuruf[6] = "G";
            IndexHuruf[7] = "H";
            IndexHuruf[8] = "I";
            IndexHuruf[9] = "J";
            IndexHuruf[10] = "K";
            IndexHuruf[11] = "L";
            IndexHuruf[12] = "M";
            IndexHuruf[13] = "N";
            IndexHuruf[14] = "O";
            IndexHuruf[15] = "P";
            IndexHuruf[16] = "Q";
            IndexHuruf[17] = "R";
            IndexHuruf[18] = "S";
            IndexHuruf[19] = "T";
            IndexHuruf[20] = "U";
            IndexHuruf[21] = "V";
            IndexHuruf[22] = "W";
            IndexHuruf[23] = "X";
            IndexHuruf[24] = "Y";
            IndexHuruf[25] = "Z";                       
        }
    }
}

