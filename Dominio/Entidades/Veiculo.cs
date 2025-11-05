using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiminalApi.Dominio.Entidades;

public class Veiculo 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(255)]
    public string nome { get; set; } = default!;

    [Required]
    [StringLength(150)]
    public string marca { get; set; } = default!;

    [Required]
    [StringLength(10)]
    public int ano { get; set; } = default!;
}