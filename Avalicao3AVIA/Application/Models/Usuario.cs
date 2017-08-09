using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Avaliacao3AVIA.Models
{
    public class Usuario
    {
        [Key]
        public int IDUsuario { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha um E-mail Válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public string Cidade { get; set; }

        public int Telefone { get; set; }
    }
}