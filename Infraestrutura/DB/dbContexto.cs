using Microsoft.EntityFrameworkCore;
using MiminalApi.Dominio.Entidades;

namespace MiminalApi.Infraestrutura.DB;

public class DBContexto : DbContext

{
    private readonly IConfiguration _configuracaoAppSettings;
    public DBContexto(IConfiguration configurationAppSettings)
    {
        _configuracaoAppSettings = configurationAppSettings;
    }
    public DbSet<Admnistrador> administradores { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admnistrador>().HasData
            (
                new Admnistrador
                {
                    Id = 1,
                    Email = "administrador@email.com.br",
                    Senha = "123456",
                    Perfil = "adm"
                }
            );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if (!optionBuilder.IsConfigured)
        {
            var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();
            if (!string.IsNullOrEmpty(stringConexao))
            {
                optionBuilder.UseMySql
                    (
                        stringConexao,
                        ServerVersion.AutoDetect(stringConexao)
                    );
            }
        }
    }

}