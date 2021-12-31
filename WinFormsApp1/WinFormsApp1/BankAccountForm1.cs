using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class BankAccountForm1 : Form
    {
        public BankAccountForm1()
        {
            InitializeComponent();
        }
        private void BTnCreateObject_click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
            

           // BankAccount bankAccount1 = new BankAccount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
        }
    }
}
