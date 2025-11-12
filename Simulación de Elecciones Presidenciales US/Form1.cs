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
            try
            {
                if (cmbestados.SelectedItem == null)
                    throw new Exception("Selecciona un estado.");

                var estadoSel = (KeyValuePair<string, int>)cmbestados.SelectedItem;

                if (!acciones.Agregarestadorep(estadoSel.Key, estadoSel.Value))
                    throw new Exception("Error al agregar estado.");

                RefrescarInterfaz();
                ActualizarGridRepublicanos();
                VerificarGanador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnagregardem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbestados.SelectedItem == null)
                    throw new Exception("Selecciona un estado.");

                var estadoSel = (KeyValuePair<string, int>)cmbestados.SelectedItem;

                if (!acciones.Agregarestadodem(estadoSel.Key, estadoSel.Value))
                    throw new Exception("Error al agregar estado.");

                RefrescarInterfaz();
                ActualizarGridDemocratas();
                VerificarGanador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnelimrep_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvrep.CurrentRow == null)
                    throw new Exception("Selecciona un estado de la tabla Republicanos.");

                string estado = dgvrep.CurrentRow.Cells[0].Value.ToString();
                int puntos = int.Parse(dgvrep.CurrentRow.Cells[1].Value.ToString());

                if (!acciones.Eliminarestadorep(estado, puntos))
                    throw new Exception("Error al eliminar estado.");

                RefrescarInterfaz();
                ActualizarGridRepublicanos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnelimdem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvdem.CurrentRow == null)
                    throw new Exception("Selecciona un estado de la tabla Demócratas.");

                string estado = dgvdem.CurrentRow.Cells[0].Value.ToString();
                int puntos = int.Parse(dgvdem.CurrentRow.Cells[1].Value.ToString());

                if (!acciones.Eliminarestadodem(estado, puntos))
                    throw new Exception("Error al eliminar estado.");

                RefrescarInterfaz();
                ActualizarGridDemocratas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRep = acciones.Mostrarrep().Sum(x => x.Value);
                int totalDem = acciones.Mostrardem().Sum(x => x.Value);

                string resultado;

                if (totalRep >= 270)
                {
                    resultado = $"🏆 ¡Republicanos ganan con {totalRep} votos!";
                    BloquearBotones();
                }
                else if (totalDem >= 270)
                {
                    resultado = $"🏆 ¡Demócratas ganan con {totalDem} votos!";
                    BloquearBotones();
                }
                else
                {
                    if (totalRep > totalDem)
                        resultado = $"Aún no hay ganador. Republicanos lideran: {totalRep} vs {totalDem}";
                    else if (totalDem > totalRep)
                        resultado = $"Aún no hay ganador. Demócratas lideran: {totalDem} vs {totalRep}";
                    else
                        resultado = $"Empate técnico. Ambos tienen {totalRep} votos.";
                }

                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular: {ex.Message}");
            }
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
            foreach (var i in acciones.Mostrarrep())
                dgvrep.Rows.Add(i.Key, i.Value);

        }

        private void ActualizarGridDemocratas()
        {
            dgvdem.Rows.Clear();
            foreach (var i in acciones.Mostrardem())
                dgvdem.Rows.Add(i.Key, i.Value);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                acciones.Limpiar();
                RefrescarInterfaz();
                dgvrep.Rows.Clear();
                dgvdem.Rows.Clear();
                HabilitarBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar: {ex.Message}");
            }
        }
        private void RefrescarInterfaz()
        {
            cmbestados.DataSource = new BindingSource(acciones.Estados, null);
        }
        private void BloquearBotones()
        {
            btnagregarrep.Enabled = false;
            btnagregardem.Enabled = false;
            btnelimrep.Enabled = false;
            btnelimdem.Enabled = false;
            btncalcular.Enabled = false;
            cmbestados.Enabled = false;


        }
        private void VerificarGanador()
        {
            try
            {
                int totalRep = acciones.Mostrarrep().Sum(x => x.Value);
            int totalDem = acciones.Mostrardem().Sum(x => x.Value);

            string resultado = "";

            if (totalRep >= 270)
            {
                resultado = $"🏆 ¡Republicanos ganan con {totalRep} votos!";
                BloquearBotones();
            }
            else if (totalDem >= 270)
            {
                resultado = $"🏆 ¡Demócratas ganan con {totalDem} votos!";
                BloquearBotones();
            }
           
            if (!string.IsNullOrEmpty(resultado))
                MessageBox.Show(resultado);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void HabilitarBotones()
        {
            btnagregarrep.Enabled = true;
            btnagregardem.Enabled = true;
            btnelimrep.Enabled = true;
            btnelimdem.Enabled = true;
            btncalcular.Enabled = true;
            cmbestados.Enabled = true;
        }
    }
}
