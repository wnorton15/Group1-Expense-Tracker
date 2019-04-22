using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB conn = new ConnectionDB("C:/Users/norton402/Documents/Cita 280/ExpenseTracker/ExpenseTrackerDB.accdb");
            string sqlString = "insert into userAccount (FirstName, LastName, Address, PhoneNumber, Income, DailyBudget) Values('";
            sqlString += textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            conn.ExecuteQuery(sqlString);
            //ConnectionDB conn2 = new ConnectionDB("C:/Users/norton402/Documents/Cita 280/ExpenseTracker/ExpenseTrackerDB.accdb");
            string sqlString2 = "insert into userInfo (userName,userPassword) Values('";
            sqlString2 += textBox5.Text + "','" + textBox6.Text + "')";
            conn.ExecuteQuery(sqlString2);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
