using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_de_Elecciones_Presidenciales_US
{
    internal class Acciones
    {
        public Dictionary<string, int> Republicanos = new Dictionary<string, int>();

        public Dictionary<string, int> Democratas = new Dictionary<string, int>();

        public Dictionary<string, int> Estados = new Dictionary<string, int>
        {
                {"AL", 9},{"AK", 3},{"AZ", 11},{"AR", 6},
                {"CA", 55},{"CO", 9},{"CT", 7},{"DE", 3},
                {"FL", 29},{"GA", 16},{"HI", 4},{"ID", 4},
                {"IL", 20},{"IN", 11},{"IA", 6},{"KS", 6},
                {"KY", 8},{"LA", 8},{"ME", 4},{"MD", 10},
                {"MA", 11},{"MI", 16},{"MN", 10},{"MS", 6},
                {"MO", 10},{"MT", 3},{"NE", 5},{"NV", 6},
                {"NH", 4},{"NJ", 14},{"NM", 5},{"NY", 29},
                {"NC", 15},{"ND", 3},{"OH", 18},{"OK", 7},
                {"OR", 7},{"PA", 20},{"RI", 4},{"SC", 9},
                {"SD", 3},{"TN", 11},{"TX", 38},{"UT", 6},
                {"VT", 3},{"VA", 13},{"WA", 12},{"WV", 5},
                {"WI", 10},{"WY", 3}
        };

        public Dictionary<string, int> Mostrarrep()
        {
            return Republicanos;
        }
        public Dictionary<string, int> Mostrardem()
        {
            return Democratas;
        }
        public bool Agregarestadorep(string estado, int puntos)
        {
            try
            {
                Republicanos.Add(estado, puntos);
                Estados.Remove(estado);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Agregarestadodem(string estado, int puntos)
        {
            try
            {
                Democratas.Add(estado, puntos);
                Estados.Remove(estado);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Eliminarestadorep(string ciudad, int puntos)
        {
            try
            {
                if (Republicanos.ContainsKey(ciudad))
                {
                    Republicanos.Remove(ciudad);
                    Estados.Add(ciudad, puntos);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Eliminarestadodem(string ciudad, int puntos)
        {
            try
            {
                if (Democratas.ContainsKey(ciudad))
                {
                    Democratas.Remove(ciudad);
                    Estados.Add(ciudad, puntos);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Limpiar()
        {
            Estados = new Dictionary<string, int>()
             {
                {"AL", 9},{"AK", 3},{"AZ", 11},{"AR", 6},
                {"CA", 55},{"CO", 9},{"CT", 7},{"DE", 3},
                {"FL", 29},{"GA", 16},{"HI", 4},{"ID", 4},
                {"IL", 20},{"IN", 11},{"IA", 6},{"KS", 6},
                {"KY", 8},{"LA", 8},{"ME", 4},{"MD", 10},
                {"MA", 11},{"MI", 16},{"MN", 10},{"MS", 6},
                {"MO", 10},{"MT", 3},{"NE", 5},{"NV", 6},
                {"NH", 4},{"NJ", 14},{"NM", 5},{"NY", 29},
                {"NC", 15},{"ND", 3},{"OH", 18},{"OK", 7},
                {"OR", 7},{"PA", 20},{"RI", 4},{"SC", 9},
                {"SD", 3},{"TN", 11},{"TX", 38},{"UT", 6},
                {"VT", 3},{"VA", 13},{"WA", 12},{"WV", 5},
                {"WI", 10},{"WY", 3}
             };

            Republicanos.Clear();
            Democratas.Clear();
        }
    }
}
    