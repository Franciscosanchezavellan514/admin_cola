using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_cola
{
    public partial class Form1 : Form
    {
        Queue<Empleados> Trabajadores = new Queue<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        public void Limpiar()
        {
            textBox_carnet.Clear();
            textBox_nombre.Clear();
            textBox_salario.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            Empleados empledado = new Empleados();
            empledado.Carnet = textBox_carnet.Text;
            empledado.Nombre = textBox_nombre.Text;
            empledado.Salario = decimal.Parse(textBox_salario.Text);
            empledado.Fecha = dateTimePicker_fecha.Value;
            Trabajadores.Enqueue(empledado);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Trabajadores.ToArray();
            Limpiar();
            textBox_carnet.Focus();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (Trabajadores.Count !=0)
            {
                Empleados empledado = new Empleados();
                empledado = Trabajadores.Dequeue();
                textBox_carnet.Text = empledado.Carnet;
                textBox_nombre.Text = empledado.Nombre;
                textBox_salario.Text = empledado.Salario.ToString();
                dateTimePicker_fecha.Value = empledado.Fecha;
                dataGridView1.DataSource = Trabajadores.ToList();
                MessageBox.Show("Se elimino los registro en cola", "Aviso");
                Limpiar() ;
            }
            else
            {
                MessageBox.Show("No hay registros en la cola", "Aviso");
            }
            textBox_carnet.Focus ();

        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_carnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
