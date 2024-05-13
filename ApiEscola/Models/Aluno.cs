using System.ComponentModel.DataAnnotations;

namespace ApiEscola.Models;

public enum NivelEscolar
{
    Infantil, 
    Fundamental,
    Medio, 
    Superior
}
public class Aluno
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do Aluno é obrigatório.")]
    public string Nome { get; set; }


    [Required(ErrorMessage = "O sobrenome do Aluno é obrigatório.")]
    public string Sobrenome { get; set; }

    [Required]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
    public string Email { get; set; }


    [Required(ErrorMessage ="A data de nascimento do aluno é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime DataNacimento { get; set; }

    public NivelEscolar Escolaridade { get; set; }   

}


