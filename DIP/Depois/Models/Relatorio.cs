namespace DIP.Depois
{
    public class Relatorio
    {
        private readonly IExportador _exportador;

        public Relatorio(IExportador exportador)
        {
            _exportador = exportador;
        }

        public void Exportar()
        {
            _exportador.Exportar();
        }
    }
}
