using System;
using System.Collections.Generic;
using Aplicacao.Interfaces;
using Dominio.Interfaces.Servico;

namespace Aplicacao
{
    public class AppServicoPadrao<TEntity> : IDisposable, IAppServicoPadrao<TEntity> where TEntity : class
    {
        private readonly IServicoPadrao<TEntity> _servicoPadrao;

        public AppServicoPadrao(IServicoPadrao<TEntity> servicoPadrao)
        {
            _servicoPadrao = servicoPadrao;
        }

        public void Adiciona(TEntity obj)
        {
            _servicoPadrao.Adiciona(obj);
        }

        public TEntity BuscaPorId(int id)
        {
            return _servicoPadrao.BuscaPorId(id);
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return _servicoPadrao.BuscaTodos();
        }

        public void Atualiza(TEntity obj)
        {
            _servicoPadrao.Atualiza(obj);
        }

        public void Exclui(TEntity obj)
        {
            _servicoPadrao.Exclui(obj);
        }

        void IAppServicoPadrao<TEntity>.Dispose()
        {
            _servicoPadrao.Dispose();
        }

        void IDisposable.Dispose()
        {
            _servicoPadrao.Dispose();
        }
    }
}
