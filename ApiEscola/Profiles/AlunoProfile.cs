using ApiEscola.Data.Dtos;
using ApiEscola.Models;
using AutoMapper;

namespace ApiEscola.Profiles;

public class AlunoProfile: Profile
{ 
    public AlunoProfile()
    {
        CreateMap<CreateAlunoDto, Aluno>();
        CreateMap<UpdateAlunoDto, Aluno>();
        CreateMap<Aluno, UpdateAlunoDto>();
        CreateMap<Aluno, ReadAlunoDto>();


    }
}
