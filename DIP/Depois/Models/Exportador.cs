using System;

namespace DIP.Depois
{
    public class ExportadorPDF : IExportador
    {
        public void Exportar()
        {
            Console.WriteLine("Exportando relatório para PDF...");
        }
    }
}
