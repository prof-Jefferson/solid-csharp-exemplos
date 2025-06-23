using System;

namespace DIP.Depois
{
    public class ExportadorExcel : IExportador
    {
        public void Exportar()
        {
            Console.WriteLine("Exportando relatório para Excel...");
        }
    }
}
