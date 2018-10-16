using Aplicacao.ViewModels;
using AutoMapper;
using Dominio.Entidades;

namespace Aplicacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlunoViewModel, Aluno>();
        }
    }
}
