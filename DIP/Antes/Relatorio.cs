namespace DIP.Antes
{
    public class Relatorio
    {
        private ExportadorPDF _exportador = new ExportadorPDF();

        public void Exportar()
        {
            _exportador.Exportar();
        }
    }
}
