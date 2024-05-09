using MISA.NVXUAN.Domain;
using System.Threading.Tasks;

namespace MISA.NVXUAN.Contracts
{
    public interface ICrudBaseService<TEntity, TDToEditEntity, TKey> 
        where TDToEditEntity : TEntity, IRecordState
    {
        Task<TDToEditEntity> GetNewAsync();
        Task DeleteAsync(TKey id);

        Task<TDToEditEntity> GetEditAsync(TKey id);
        Task<TDToEditEntity> SubmitEntity(TDToEditEntity record);
    }
}
