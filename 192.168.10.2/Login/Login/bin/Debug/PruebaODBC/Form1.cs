using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCMySqlConnect;

namespace PruebaODBC
{
    public partial class Form1 : Form
    {
        DBConnect db = new DBConnect("noelia");
        public Form1()
        {
            InitializeComponent();
        }

        private void consultar()
        {
            string query = "select * from usuario";
            dataGridView1.DataSource = db.consultarGrid(query).DataSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "cliente";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre", textBox1.Text);
            dict.Add("direccion", textBox2.Text);
            db.insertar(tabla, dict);
            consultar();
        }
    }
}
