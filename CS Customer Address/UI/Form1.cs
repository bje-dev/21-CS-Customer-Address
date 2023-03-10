using BLL.Contracts;
using BLL.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Customer customer = new Customer();

            customer.Nombre = textBox1.Text;
            customer.Apellido = textBox2.Text;
            customer.Email = textBox3.Text;
            customer.Edad = Convert.ToInt32(textBox4.Text);

            IGenericBusinessLogic<Customer> addresbl = new CustomerBusinessLogic();

            addresbl.Insert(customer);

        }
    }
}
