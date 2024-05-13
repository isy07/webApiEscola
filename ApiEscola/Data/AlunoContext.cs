using ApiEscola.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEscola.Data;

public class AlunoContext: DbContext
{
    public AlunoContext(DbContextOptions<AlunoContext> opts) : base(opts) 
    {
        
    }
    public DbSet<Aluno> Alunos { get; set; }
}
