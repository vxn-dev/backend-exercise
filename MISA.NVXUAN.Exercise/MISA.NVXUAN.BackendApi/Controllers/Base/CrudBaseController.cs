using Microsoft.AspNetCore.Mvc;
using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain;
using System.Threading.Tasks;

namespace MISA.NVXUAN.BackendApi.Controllers
{
    public abstract class CrudBaseController<TService, TEntity, TDToEditEntity, TKey> : Controller 
        where TDToEditEntity : TEntity, IRecordState
        where TService : ICrudBaseService<TEntity, TDToEditEntity, TKey>
    {

        protected readonly TService _service;

        public CrudBaseController(TService service)
        {
            _service = service;
        }

        [HttpGet("edit/{id}")]
        public async virtual Task<IActionResult> GetEdit(TKey id)
        {
            var result = await _service.GetEditAsync(id);
            if(result == null)
            {
                return NotFound("Không tìm thấy");
            }
            return Ok(result);
        }

        [HttpGet("new")]
        public async virtual Task<IActionResult> GetNew()
        {
            var result = await _service.GetNewAsync();
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public async virtual Task<IActionResult> Delete(TKey id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }

        [HttpPost("insert")]
        public async virtual Task<IActionResult> Insert(TDToEditEntity record)
        {
            record.state = 1;
            var result = await _service.SubmitEntity(record);
            return Ok(result);
        }

        [HttpPut("update")]
        public async virtual Task<IActionResult> Update(TDToEditEntity record)
        {
            record.state = 2;
            var result = await _service.SubmitEntity(record);
            return Ok(result);
        }
    }
}
