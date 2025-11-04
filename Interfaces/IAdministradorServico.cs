using MiminalApi.Dominio.Entidades;
using MiminalApi.DTOs;

namespace miminal_api.Interfaces
{
    public interface IAdministradorServico
    {

        Admnistrador? Login(LoginDTO loginDTO);
    }
}
