using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao
{
    public class AlunoAppServico : AppServicoPadrao<Aluno>, IAlunoAppServico
    {
        private readonly IAlunoServico _alunoServico;

        public AlunoAppServico(IAlunoServico alunoServico) : base(alunoServico)
        {
            _alunoServico = alunoServico;
        }

        
    }
}
