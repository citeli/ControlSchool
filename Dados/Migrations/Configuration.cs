using System.Collections.Generic;
using Dados.Context;
using Dominio.Entidades;

namespace Dados.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            /*
            var cursoSeed = new Curso()
            {
                Descricao = "curso seed descricao",
                DataCadastro = DateTime.Now,
                NomeCurso = "curso seed"
            };

            IList<Turma> turmas = new List<Turma>();
            turmas.Add(new Turma()
            {
                DataCadastro = DateTime.Now,
                DataInicio = DateTime.Today,
                DataFim = DateTime.Today,
                Descricao = "teste turma",
                Horario = "20h30",
                Curso = cursoSeed
            });

            context.Cursos.Add(cursoSeed); //Adiciona o objeto
            context.Turmas.AddRange(turmas); //Adiciona uma lista de objetos
            */
        }
    }
}
