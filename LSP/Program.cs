using System;
using System.Collections.Generic;

namespace LSP.Depois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAve> aves = new List<IAve>
            {
                new Andorinha(),
                new Pinguim()
            };

            foreach (var ave in aves)
            {
                ave.Bicar();
            }

            Console.WriteLine("\nAves voadoras:");
            List<IAveVoadora> voadoras = new List<IAveVoadora>
            {
                new Andorinha()
            };

            foreach (var voadora in voadoras)
            {
                voadora.Voar();
            }
        }
    }
    
    /*
    Benefícios:
        Pinguim não precisa fingir que voa;

        Andorinha pode ser usada como IAve ou IAveVoadora;

        Você respeita completamente o LSP, evitando substituições incorretas.
    */
}
