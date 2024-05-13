using ApiEscola.Models;
using Microsoft.AspNetCore.Mvc;
using ApiEscola.Data;
using AutoMapper;
using ApiEscola.Data.Dtos;
using System.Runtime.CompilerServices;
namespace ApiEscola.Controllers;


[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private AlunoContext _context;
    private IMapper _mapper;
    public AlunoController(AlunoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    //public IActionResult DataNacimento([FromBody] Aluno aluno) 
    //{
    //    DateTime data = aluno.DataNacimento;
    //
    //}
    public IActionResult AdicionarAluno([FromBody] CreateAlunoDto alunoDto)
    {
        Aluno aluno = _mapper.Map<Aluno>(alunoDto);
        _context.Alunos.Add(aluno);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaAlunoPorId),
            new { id = aluno.Id },
            aluno);
    }



    [HttpGet]
    public IEnumerable<ReadAlunoDto> RecuperaAlunos([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadAlunoDto>>(_context.Alunos.Skip(skip).Take(take));
    }
    [HttpGet("{id}")]
    public IActionResult RecuperaAlunoPorId(int id)
    {
        var aluno = _context.Alunos
            .FirstOrDefault(aluno => aluno.Id == id);
        if (aluno == null) return NotFound();
        var alunoDto = _mapper.Map<ReadAlunoDto>(aluno);
        return Ok(alunoDto);
    }

    [HttpPut("{id}")]

    public IActionResult AtualizaAluno(int id, [FromBody] 
        UpdateAlunoDto alunoDto)
    {
        var aluno = _context.Alunos .FirstOrDefault(
            aluno => aluno.Id == id);   
        if(aluno == null) return NotFound();
        _mapper.Map(alunoDto, aluno);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]

    public IActionResult DeletaAluno(int id)
    {
        var aluno = _context.Alunos.FirstOrDefault(
            aluno => aluno.Id == id);
        if (aluno == null) return NotFound();
        _context.Remove(aluno);
        _context.SaveChanges();
        return NoContent();
    }

}
