using Prova_H1.Models;

namespace Prova_H1.Services
{
    public interface IIntegranteRepository
    {

        public List<DadosIntegrante> obterTodosIntegrantes();
        public DadosIntegrante obterdobterIntegranteporNomea(string cpf);

        public void Inserir(DadosIntegrante novoIntegrante);

    }
}