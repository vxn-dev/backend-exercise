using MISA.NVXUAN.Library.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MISA.NVXUAN.Data
{
    public class BaseData<TEntity>
    {
        private List<TEntity> _data;
        private PropertyInfo _keyProp;
        public BaseData()
        {
            _data = new List<TEntity>();
            _keyProp = new TypeService().GetKeyField(typeof(TEntity));
            if (_keyProp == null) throw new Exception("Chưa cấu hình keyattribute");
        }
        public List<TEntity> AllData { get { 
            return _data;
        } }

        public int Length { get {
            return _data.Count;    
        } }

        public void Insert(TEntity data)
        {
            if(data == null) throw new Exception("[Insert - CustomerData] data is null");
            _data.Add(data);
        }
        public void Delete(object keyValue)
        {
            if (keyValue == null) throw new Exception("[Delete - CustomerData] keyValue is null");
            var delData = _data.Where(e => _keyProp.GetValue(e) == keyValue).ToList();
            delData.ForEach(e => _data.Remove(e));
        }

        public void Update(TEntity entity)
        {
            if (entity == null) throw new Exception("[Update - CustomerData] entity is null");
            var keyValue = _keyProp.GetValue(entity);
            var fIndex = _data.FindIndex(e => _keyProp.GetValue(e) == keyValue);
            if(fIndex > -1) _data[fIndex] = entity;
        }
    }
}
