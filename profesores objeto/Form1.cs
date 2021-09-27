using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace profesores_objeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void filldgv()
        {
            dgv.Columns.Add("PID", "ID DEL PROFESOR");
            dgv.Columns.Add("Pnombre", "NOMBRE DEL PROFESOR");
            dgv.Columns.Add("Pasignatura", "ASIGNATURA DEL PROFESOR");
            dgv.Columns.Add("Pgrupo", "GRUPO DEL PROFESOR");

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores();
            profesores.PID = txbID.Text;
            profesores.Pnombre = txbName.Text;
            profesores.Pasignatura = txbAsignatura.Text;
            profesores.Pgrupo = txbGrupo.Text;

            dgv.Rows.Add(
                profesores.PID,
                profesores.Pnombre,
                profesores.Pasignatura,
                profesores.Pgrupo
                );
        }
    }
}
