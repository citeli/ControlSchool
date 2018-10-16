using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;

namespace Dominio.Servicos
{
    public class CursoServico : ServicoPadrao<Curso>, ICursoServico
    {
        private readonly ICursoRepositorio _cursoRepositorio;

        public CursoServico(ICursoRepositorio cursoRepositorio) : base(cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }
    }
}
