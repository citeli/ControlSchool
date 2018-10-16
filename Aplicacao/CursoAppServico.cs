using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao
{
    public class CursoAppServico : AppServicoPadrao<Curso>, ICursoAppServico
    {
        private readonly ICursoServico _cursoServico;

        public CursoAppServico(ICursoServico cursoServico) : base(cursoServico)
        {
            _cursoServico = cursoServico;
        }
    }
}
