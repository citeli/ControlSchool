using Aplicacao.ViewModels;
using AutoMapper;
using Dominio.Entidades;

namespace Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Aluno, AlunoViewModel>();
        }
    }
}
