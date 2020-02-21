using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Udarbejd et lille program, 
 * der udskriver dagen i tekst, 
 * når der indtastes et ugedagsnummer
 */

namespace KEAOpgave_3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch (textBoxNumber.Text)
            {
                case "0":
                    labelDay.Text = "Monday";
                    break;
                case "1":
                    labelDay.Text = "Tuesday";
                    break;
                case "2":
                    labelDay.Text = "Wednesday";
                    break;
                case "3":
                    labelDay.Text = "Thursday";
                    break;
                case "4":
                    labelDay.Text = "Friday";
                    break;
                case "5":
                    labelDay.Text = "Saturday";
                    break;
                case "6":
                    labelDay.Text = "Sunday";
                    break;
                default:
                    labelDay.Text = "WRONG! YOU NUB!";
                    break;
            }
        }
    }
}
