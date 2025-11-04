using miminal_api.Interfaces;
using MiminalApi.Dominio.Entidades;
using MiminalApi.DTOs;
using MiminalApi.Infraestrutura.DB;

namespace miminal_api.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly DBContexto _contexto;
        public AdministradorServico(DBContexto contexto ) 
        {
            _contexto = contexto;
        }

        public Admnistrador? Login (LoginDTO loginDTO)
        {
            var adm = _contexto.administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
        }
    }
}
