using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Models
{
   public class BankAccount
    {
        public int id;
        public string Name;
        public decimal Balance;

        
    }
    public BankAccount()
    {
        MessageBox.Show("Bank account object Created");
    }



}
