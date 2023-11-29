using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMiaScuola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente marco = new Studente();


            foreach (Voto voto in marco.Voti)
            {
                Console.WriteLine("{0} {1} {2}", voto.Data, voto.Valore, voto.Materia.Sigla);
            }

        }
    }
}
