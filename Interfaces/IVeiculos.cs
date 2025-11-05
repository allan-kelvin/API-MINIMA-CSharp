using MiminalApi.Dominio.Entidades;
using MiminalApi.DTOs;

namespace miminal_api.Interfaces
{
    public interface IVeiculoServico
    {

        List<Veiculo> Todos(int pagina=1, string? nome = null, string? marca = null);

        Veiculo? BuscarPorId(int id);

        void Incluir(Veiculo veiculo);
        void Atualizar(Veiculo veiculo);
        void ApagarPorId(Veiculo veiculo);
    }
}
