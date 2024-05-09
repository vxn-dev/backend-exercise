using MISA.NVXUAN.DomainShared.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MISA.NVXUAN.Library.Service
{
    public interface ITypeService
    {
        List<PropertyInfo> GetKeyFields(Type type);
        Dictionary<PropertyInfo, DetailAttribute> GetDetailFields(Type type);
        PropertyInfo GetKeyField(Type type);
        List<PropertyInfo> GetFieldByAttr<TAttribute>(Type type) where TAttribute : Attribute;
    }
}
