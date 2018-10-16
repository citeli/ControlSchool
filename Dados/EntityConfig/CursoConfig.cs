using System.Data.Entity.ModelConfiguration;
using Dominio.Entidades;

namespace Dados.EntityConfig
{
    public class CursoConfig : EntityTypeConfiguration<Curso>
    {
        public CursoConfig()
        {
            ToTable("Cursos");
            Property(curso => curso.NomeCurso).HasMaxLength(50).IsRequired();
            Property(curso => curso.Descricao).HasMaxLength(100).IsRequired();
            Property(curso => curso.DataCadastro).HasColumnType("datetime").IsRequired();

            HasMany(curso => curso.Turmas)
                .WithRequired(turma => turma.Curso);
        }
    }
}
