using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudMYSQLCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.guardarAlumnos(txtnombres,txtapellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void dgvTotalAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.seleccionarAlumnos(dgvTotalAlumnos,txtid,txtnombres,txtapellidos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.modificarAlumnos(txtid,txtnombres, txtapellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.eliminarAlumnos(txtid);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }
    }
}
