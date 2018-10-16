using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao
{
    public class ProfessorAppServico : AppServicoPadrao<Professor>, IProfessorAppServico
    {
        private readonly IProfessorServico _professorServico;

        public ProfessorAppServico(IProfessorServico professorServico) : base(professorServico)
        {
            _professorServico = professorServico;
        }
    }
}
