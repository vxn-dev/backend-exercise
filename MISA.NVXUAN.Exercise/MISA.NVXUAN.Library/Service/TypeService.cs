using MISA.NVXUAN.DomainShared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MISA.NVXUAN.Library.Service
{
    public class TypeService: ITypeService
    {
        public List<PropertyInfo> GetKeyFields(Type type)
        {
            return GetFieldByAttr<KeyAttribute>(type);
        }

        public Dictionary<PropertyInfo, DetailAttribute> GetDetailFields(Type type)
        {
            var dic = new Dictionary<PropertyInfo, DetailAttribute>();

            var props = GetFieldByAttr<DetailAttribute>(type);

            if(props != null && props.Count > 0)
            {
                props.ForEach(p =>
                {
                    var detailAttribute = p.GetCustomAttribute<DetailAttribute>();
                    dic.Add(p, detailAttribute);
                });
            }

            return dic;
        }

        public PropertyInfo GetKeyField(Type type)
        {
            return GetKeyFields(type).FirstOrDefault();
        }

        public List<PropertyInfo> GetFieldByAttr<TAttribute>(Type type) where TAttribute : Attribute
        {
            var result = new List<PropertyInfo>();

            if (type == null) return result;

            var props = type.GetProperties().ToList();

            result = props.Where(e => e.GetCustomAttribute<TAttribute>() != null).ToList();

            return result;
        }
    }
}
