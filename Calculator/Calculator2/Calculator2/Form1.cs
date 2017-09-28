using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool isTypingNumber = false;
<<<<<<< HEAD
        enum PhepToan { None,Cong, Tru, Nhan,Chia};
=======
        enum PhepToan { Cong, Tru, Nhan, Chia, Can,PhanTram,DoiDau};
>>>>>>> 5bdf69bcaa11626964b8d5d47e0c5ac8764ee263
        PhepToan pheptoan;

        double nho = 0.0;

        private void btn1_Click(object sender, EventArgs e)
        {
            NhapSo("1");
        }
        private void NhapSo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NhapSo(btn.Text);
        }
        





        private void NhapSo(string so)
        {
            if (isTypingNumber)
                lblDisplay.Text = lblDisplay.Text + so;
            else
                lblDisplay.Text = so;
            isTypingNumber = true;
    
         }
<<<<<<< HEAD
        private void btnCach_Click(object sender, EventArgs e)
        {
            lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, lblDisplay.Text.Length);
        }

=======
        private void btnNho_Click(object sender, EventArgs e)
        {
            

            lblDisplay.Text.Remove(lblDisplay.Text.Length-1);

        }
>>>>>>> 5bdf69bcaa11626964b8d5d47e0c5ac8764ee263
        private void NhapPhepToan(object sender, EventArgs e)
        {
            if (nho != 0)
                TinhKetQua();

            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+": pheptoan = PhepToan.Cong; break;
                case "-": pheptoan = PhepToan.Tru; break;
                case "*": pheptoan = PhepToan.Nhan; break;
                case "/": pheptoan = PhepToan.Chia; break;
<<<<<<< HEAD
            }
=======
                case "√": pheptoan = PhepToan.Can; break;
                case "%": pheptoan = PhepToan.PhanTram; break;
                case "-/+": pheptoan = PhepToan.DoiDau;break;


            }
            TinhKetQua();
>>>>>>> 5bdf69bcaa11626964b8d5d47e0c5ac8764ee263

            nho = double.Parse(lblDisplay.Text);

            isTypingNumber = false;
        }

        private void TinhKetQua()
        {
            //tinh toan dua tren : nho, pheptoan, lbldisplay.text
            double tam = double.Parse(lblDisplay.Text);
            double ketqua = 0.0;
            switch (pheptoan)
            {
                case PhepToan.Cong: ketqua = nho + tam; break;
                case PhepToan.Tru: ketqua = nho - tam; break;
                case PhepToan.Chia: ketqua = nho / tam; break;
                case PhepToan.Nhan: ketqua = nho * tam; break;
                case PhepToan.Can: ketqua = Math.Sqrt(tam); break;
                case PhepToan.PhanTram: ketqua = tam / 100; break;
                case PhepToan.DoiDau: ketqua = tam * (-1);break;


            }


            lblDisplay.Text = ketqua.ToString();

            // gan ket qua tinh duoc len display

        }
<<<<<<< HEAD
        private void btnXoa_Click(object sender, EventArgs e)
        {
            nho = 0;
            lblDisplay.Text = "0";
        }

        private void btnBang_Click(object sender, EventArgs e)
=======
         private void btnBang_Click(object sender, EventArgs e)
>>>>>>> 5bdf69bcaa11626964b8d5d47e0c5ac8764ee263
        {
            TinhKetQua();
            isTypingNumber = false;
            nho = 0;
            pheptoan = PhepToan.None;
        }


        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':

                    NhapSo("" + e.KeyChar);
                    break;
            }
                
<<<<<<< HEAD
=======
       }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nho = 0;
            lblDisplay.Text = "0";
>>>>>>> 5bdf69bcaa11626964b8d5d47e0c5ac8764ee263
        }

        
    }
}
