using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nome { get; set; }
        [StringLength(100)]
        public string diciplina { get; set; }

        public float nota1 { get; set; }
        public float nota2 { get; set; }
    }


}


