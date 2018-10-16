using Aplicacao;
using Aplicacao.Interfaces;
using Dados.Repositorios;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;
using Dominio.Servicos;
using SimpleInjector;

namespace InversaoDeControle
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            //Aplicação
            container.Register<IAlunoAppServico, AlunoAppServico>();
            container.Register<ICursoAppServico, CursoAppServico>();
            container.Register<IProfessorAppServico, ProfessorAppServico>();
            container.Register<ITurmaAppServico, TurmaAppServico>();

            //Dominio
            container.Register<IAlunoServico, AlunoServico>();
            container.Register<ICursoServico, CursoServico>();
            container.Register<IProfessorServico, ProfessorServico>();
            container.Register<ITurmaServico, TurmaServico>();

            //Infra Dados
            container.Register<IAlunoRepositorio, AlunoRepositorio>();
            container.Register<ICursoRepositorio, CursoRepositorio>();
            container.Register<IProfessorRepositorio, ProfessorRepositorio>();
            container.Register<ITurmaRepositorio, TurmaRepositorio>();
        }
    }
}
