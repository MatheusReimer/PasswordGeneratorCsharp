using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countCheck = 0;

            if (checkBox1.Checked) { countCheck++; Generate(6, countCheck); }
            else if (checkBox2.Checked) { countCheck++; Generate(10, countCheck); }
            else if (checkBox3.Checked) { countCheck++; Generate(12, countCheck); }
            else if (checkBox4.Checked) { countCheck++; Generate(15, countCheck); }
            else { Generate(6, 0); }



        }


        public void Generate(int len, int countCheck)
        {
            Console.WriteLine(countCheck);
            if (countCheck > 1)
            {
                MessageBox.Show("Você só pode selecionar um tamanho de senha", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();

            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }

            textBox1.Text = result.ToString();

        }


    }
}
