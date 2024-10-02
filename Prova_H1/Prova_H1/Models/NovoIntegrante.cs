using System.ComponentModel.DataAnnotations;

namespace Prova_H1.Models
{
    public class NovoIntegrante
    {

        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Obrigatório")]

        public string DecricaoB { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        
        public int idade { get; set; }

        public void cadastrarintegrante()
        {

        }

    }
}
