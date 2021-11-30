using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        //connect the database into this line 
        SqlConnection con = new SqlConnection(@"Data Source=rakibul-erp;Initial Catalog=Employee;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This code is a part of insert the new employee
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO employee_list VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Employee information is updated succussfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Insert data Sucessfully","Insert",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This code is part of the new from section.
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This code is a part of the udate section
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE employee_list SET Employee_Name = '" +textBox2.Text+ "',Address = '"+textBox3.Text+"',Salary = '"+ textBox4.Text +"' WHERE Employee_ID = '"+textBox1.Text+ "'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data Sucessfully");
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE employee_list WHERE Employee_ID ='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data Sucessfully");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Tis is the code for the clear button.
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = comboBox1.Text = "";
        }
    } 
}