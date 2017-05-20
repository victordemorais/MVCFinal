using MVC_Final.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Final.Models.Repositorios
{
    public class AlunoRecepitorio
    {
        private Contexto ctx = new Contexto();
        public void Adicionar(Aluno Alunos)
        {
            ctx.Alunos.Add(Alunos);
            ctx.SaveChanges();
        }
        public void Remove(Aluno Alunos)
        {
            ctx.Alunos.Remove(Alunos);
            ctx.SaveChanges();
        }
        public List<Aluno> ListarTodos()
        {
            return ctx.Alunos.ToList();
        }
       
    }
}