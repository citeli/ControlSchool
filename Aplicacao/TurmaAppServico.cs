using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao
{
    public class TurmaAppServico : AppServicoPadrao<Turma>, ITurmaAppServico
    {
        private readonly ITurmaServico _turmaServico;

        public TurmaAppServico(ITurmaServico turmaServico) : base(turmaServico)
        {
            _turmaServico = turmaServico;
        }
    }
}
