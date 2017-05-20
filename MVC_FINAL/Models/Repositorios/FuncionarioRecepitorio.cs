using MVC_Final.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Final.Models.Repositorios
{
    public class FuncionarioRecepitorio
    {
        private Contexto ctx = new Contexto();
        public void Adicionar(Funcionario funcionarios)
        {
            ctx.Funcionarios.Add(funcionarios);
            ctx.SaveChanges();
        }
        public void Remove(Funcionario funcionarios)
        {
            ctx.Funcionarios.Remove(funcionarios);
            ctx.SaveChanges();
        }
        public List<Funcionario> ListarTodos()
        {
            return ctx.Funcionarios.ToList();
        }
    }
}