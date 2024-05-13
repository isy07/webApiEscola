using ApiEscola.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiEscola.Data.Dtos
{
    public class ReadAlunoDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNacimento { get; set; }
        public NivelEscolar Escolaridade { get; set; }
    }
}
