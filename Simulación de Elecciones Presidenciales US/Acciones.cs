using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            { "AL", 9 },
            { "AK", 3 },
            { "AZ", 11 },
            { "AR", 6 },
            { "CA", 54 },
            { "CO", 10 },
            { "CT", 7 },
            { "DE", 3 },
            { "FL", 30 },
            { "GA", 16 },
            { "HI", 4 },
            { "ID", 4 },
            { "IL", 19 },
            { "IN", 11 },
            { "IA", 6 },
            { "KS", 6 },
            { "KY", 8 },
            { "LA", 8 },
            { "ME", 4 },
            { "MD", 10 },
            { "MA", 11 },
            { "MI", 15 },
            { "MN", 10 },
            { "MS", 6 },
            { "MO", 10 },
            { "MT", 4 },
            { "NE", 5 },
            { "NV", 6 },
            { "NH", 4 },
            { "NJ", 14 },
            { "NM", 5 },
            { "NY", 28 },
            { "NC", 16 },
            { "ND", 3 },
            { "OH", 17 },
            { "OK", 7 },
            { "OR", 8 },
            { "PA", 19 },
            { "RI", 4 },
            { "SC", 9 },
            { "SD", 3 },
            { "TN", 11 },
            { "TX", 40 },
            { "UT", 6 },
            { "VT", 3 },
            { "VA", 13 },
            { "WA", 12 },
            { "WV", 4 },
            { "WI", 10 },
            { "WY", 3 },
            { "DC", 3 }
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

    }
}
