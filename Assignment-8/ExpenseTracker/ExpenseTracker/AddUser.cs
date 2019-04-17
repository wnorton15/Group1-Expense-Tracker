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
            string sqlString = "insert into userAccount (FirstName, LastName) Values('";
            sqlString += textBox1.Text + "','" + textBox2.Text + "')";
            conn.ExecuteQuery(sqlString);
        }

    }
}
