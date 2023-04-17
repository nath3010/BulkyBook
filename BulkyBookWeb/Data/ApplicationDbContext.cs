using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{   
    //DbContext é do pacote entityframework core
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)//passando para a classe bae
        {   
            
        }

        //para criar a tabela dentro do banco de dados
        public DbSet<Category> Categories { get; set; }
    }
}
