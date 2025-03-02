using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProgBroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbroma_Click(object sender, EventArgs e)
        {

        }
        bool exte = true;
        int A = 0;
        int B = 0;
        int postA = 0;
        int postB = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbroma_MouseEnter(object sender, EventArgs e)
        {
            exte = true;

            while (exte)
            {
                A = random.Next(32, 400);

                if (postA + 100 < A || postA - 100 < A)
                {
                    exte = false;
                }
            }

            exte = true;

            while (exte)
            {
                B = random.Next(35, 400);

                if (postB + 100 < B || postB - 100 < B)
                {
                    exte = false;
                }
            }

            btnbroma.Location = new Point(A, B);
            postA = A;
            postB = B;
        }

        Random random = new Random();
    }
}
    