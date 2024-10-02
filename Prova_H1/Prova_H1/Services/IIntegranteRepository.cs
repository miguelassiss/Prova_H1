using Prova_H1.Models;

namespace Prova_H1.Services
{
    public class IntergranteRepository : IIntegranteRepository
    {

        private static List<DadosIntegrante> dadosIntegrantesList = new List<DadosIntegrante>();

        public IntegranteRepository() { }

        public void Inserir(DadosIntegrante novoIntegrante)
        {
            dadosIntegrantesList.Add(novoIntegrante);
        }

        public DadosIntegrante obterIntegranteporNome(string Nome)
        {
            return dadosIntegrantesList.Where(a => a.Nome == Nome).FirstOrDefault();

        }

        public List<DadosIntegrante> obterTodosIntegrantes()
        {
            return dadosIntegrantesList;
        }
    }
}