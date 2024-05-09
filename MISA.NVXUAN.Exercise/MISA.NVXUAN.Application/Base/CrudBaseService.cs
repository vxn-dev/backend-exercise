using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain;
using MISA.NVXUAN.Library.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NVXUAN.Application
{
    public class CrudBaseService<TEntity, TDToEditEntity, TKey> : ICrudBaseService<TEntity, TDToEditEntity, TKey>
        where TDToEditEntity : TEntity, IRecordState
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly ITypeService _typeService;

        public CrudBaseService(IServiceProvider serviceProvider){
            _serviceProvider = serviceProvider;
        }

        public virtual async Task<TDToEditEntity> GetNewAsync()
        {
            return Activator.CreateInstance<TDToEditEntity>();
        }

        public virtual async Task DeleteAsync(TKey id){}

        public virtual async Task<TDToEditEntity> GetEditAsync(TKey id)
        {
            return Activator.CreateInstance<TDToEditEntity>();
        }

        public virtual async Task<TDToEditEntity> SubmitEntity(TDToEditEntity record)
        {
            return record;
        }
    }
}
