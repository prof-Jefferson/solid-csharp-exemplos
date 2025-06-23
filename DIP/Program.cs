using System;

namespace DIP.Antes
{
    class Program
    {
        static void Main(string[] args)
        {
            var relatorio = new Relatorio();
            relatorio.Exportar();
        }
    }
    
    /*
         Problema:
            A classe Relatorio depende diretamente da classe concreta ExportadorPDF.
            Se você quiser exportar para Excel ou CSV, terá que modificar a classe Relatorio, 
            o que viola o OCP e o DIP.
    */
}
