using System.ComponentModel.DataAnnotations;

namespace ProjetoDBZ.models
{
    public class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [MaxLength(120, ErrorMessage ="Nome precisa ter no máximo 120 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Tipo é um campo obrigatório")]
        [MaxLength(50, ErrorMessage ="Tipo precisa ter no máximo 50 caracteres")]
        public string Tipo { get; set; }
    }
}