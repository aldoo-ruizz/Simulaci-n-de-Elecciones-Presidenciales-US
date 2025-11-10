using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulación_de_Elecciones_Presidenciales_US
{
    public partial class Form1 : Form
    {
        Acciones acciones = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregarrep_Click(object sender, EventArgs e)
        {
            if (cmbestados.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un estado");
                return;
            }

            string estado = ((KeyValuePair<string, int>)cmbestados.SelectedItem).Key;
            int puntos = ((KeyValuePair<string, int>)cmbestados.SelectedItem).Value;

            if (acciones.Agregarestadorep(estado, puntos))
            {
                MessageBox.Show($"Estado {estado} agregado a Republicanos.");
                cmbestados.DataSource = new BindingSource(acciones.Estados, null);
                ActualizarGridRepublicanos();
            }
            else
            {
                MessageBox.Show("Error al agregar estado.");
            }
        }

        private void btnagregardem_Click(object sender, EventArgs e)
        {
            if (cmbestados.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un estado");
                return;
            }

            string estado = ((KeyValuePair<string, int>)cmbestados.SelectedItem).Key;
            int puntos = ((KeyValuePair<string, int>)cmbestados.SelectedItem).Value;

            if (acciones.Agregarestadodem(estado, puntos))
            {
                MessageBox.Show($"Estado {estado} agregado a Demócratas.");
                cmbestados.DataSource = new BindingSource(acciones.Estados, null);
                ActualizarGridDemocratas();
            }
            else
            {
                MessageBox.Show("Error al agregar estado.");
            }
        }

        private void btnelimrep_Click(object sender, EventArgs e)
        {
            if (dgvrep.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un estado de la tabla Republicanos.");
                return;
            }

            string estado = dgvrep.CurrentRow.Cells[0].Value.ToString();
            int puntos = int.Parse(dgvrep.CurrentRow.Cells[1].Value.ToString());

            if (acciones.Eliminarestadorep(estado, puntos))
            {
                MessageBox.Show($"Estado {estado} eliminado de Republicanos.");
                cmbestados.DataSource = new BindingSource(acciones.Estados, null);
                ActualizarGridRepublicanos();
            }
            else
            {
                MessageBox.Show("Error al eliminar estado.");
            }
        }

        private void btnelimdem_Click(object sender, EventArgs e)
        {
            if (dgvdem.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un estado de la tabla Demócratas.");
                return;
            }

            string estado = dgvdem.CurrentRow.Cells[0].Value.ToString();
            int puntos = int.Parse(dgvdem.CurrentRow.Cells[1].Value.ToString());

            if (acciones.Eliminarestadodem(estado, puntos))
            {
                MessageBox.Show($"Estado {estado} eliminado de Demócratas.");
                cmbestados.DataSource = new BindingSource(acciones.Estados, null);
                ActualizarGridDemocratas();
            }
            else
            {
                MessageBox.Show("Error al eliminar estado.");
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int totalRep = acciones.Mostrarrep().Sum(x => x.Value);
            int totalDem = acciones.Mostrardem().Sum(x => x.Value);

            string resultado;
            if (totalRep >= 270)
                resultado = $"🏆 ¡Republicanos ganan con {totalRep} votos!";
            else if (totalDem >= 270)
                resultado = $"🏆 ¡Demócratas ganan con {totalDem} votos!";
            else
                resultado = $"Republicanos: {totalRep} | Demócratas: {totalDem}";

            MessageBox.Show(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbestados.DataSource = new BindingSource(acciones.Estados, null);
            cmbestados.DisplayMember = "Key";
            cmbestados.ValueMember = "Value";

            dgvrep.Columns.Add("Estado", "Estado");
            dgvrep.Columns.Add("Puntos", "Puntos");
            dgvdem.Columns.Add("Estado", "Estado");
            dgvdem.Columns.Add("Puntos", "Puntos");
        }
        private void ActualizarGridRepublicanos()
        {
            dgvrep.Rows.Clear();
            foreach (var kvp in acciones.Mostrarrep())
                dgvrep.Rows.Add(kvp.Key, kvp.Value);
            
        }

        private void ActualizarGridDemocratas()
        {
            dgvdem.Rows.Clear();
            foreach (var kvp in acciones.Mostrardem())
                dgvdem.Rows.Add(kvp.Key, kvp.Value);
        }
    }
    }

