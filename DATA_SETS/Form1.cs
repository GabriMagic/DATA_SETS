using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATA_SETS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdBibliotecaDataSet.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bdBibliotecaDataSet.libros);
            // TODO: esta línea de código carga datos en la tabla 'bdBibliotecaDataSet.autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this.bdBibliotecaDataSet.autores);
            // TODO: esta línea de código carga datos en la tabla 'bdBibliotecaDataSet.ejemplares' Puede moverla o quitarla según sea necesario.
            this.ejemplaresTableAdapter.Fill(this.bdBibliotecaDataSet.ejemplares);

            label3.Text =(dataGridView1.RowCount - 1).ToString()+" Autores";
            label4.Text = (dataGridView2.RowCount - 1).ToString()+" Ejemplares";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
