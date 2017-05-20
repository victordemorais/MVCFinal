using MVC_Final.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Final.Models.Repositorios
{
    public class Contexto : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public Contexto() : base("Conexao")
   {
            Database.SetInitializer<Contexto>(new CreateDatabaseIfNotExists<Contexto>());
        }

    }
  



}