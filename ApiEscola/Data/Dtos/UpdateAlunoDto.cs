using ApiEscola.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiEscola.Data.Dtos;

public class UpdateAlunoDto
{
    [Required(ErrorMessage = "O nome do Aluno é obrigatório.")]
    public string Nome { get; set; }


    [Required(ErrorMessage = "O sobrenome do Aluno é obrigatório.")]
    public string Sobrenome { get; set; }

    [Required]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
    public string Email { get; set; }


    [Required(ErrorMessage = "A data de nascimento do aluno é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime DataNacimento { get; set; }

    public NivelEscolar Escolaridade { get; set; }
}

