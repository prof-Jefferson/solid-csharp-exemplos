using System;

namespace DIP.Depois
{
    class Program
    {
        static void Main(string[] args)
        {
            IExportador exportador = new ExportadorPDF();
            var relatorio = new Relatorio(exportador);
            relatorio.Exportar();

            Console.WriteLine();

            IExportador outroExportador = new ExportadorExcel();
            var relatorioExcel = new Relatorio(outroExportador);
            relatorioExcel.Exportar();
        }
    }
}
