using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.DomainShared.Attributes
{
    public class DetailAttribute : Attribute
    {
        public string MasterKeyField { get; set; }
        public Type Type { get; set; }
        public DetailAttribute(string masterKey, Type type)
        {
            this.MasterKeyField = masterKey;
            this.Type = type;
        }
    }
}
