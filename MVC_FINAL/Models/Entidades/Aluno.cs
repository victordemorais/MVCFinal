﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Final.Models.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}