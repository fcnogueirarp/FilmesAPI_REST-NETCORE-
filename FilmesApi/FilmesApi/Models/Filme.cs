using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero não pode ultrapassar 30 caracter")]
        public string Genero { get; set; }
        [Range(1,600, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 600")]
        public int Duracao { get; set; }
        
    }
}
