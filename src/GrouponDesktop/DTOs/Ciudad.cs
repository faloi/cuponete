using System;
using System.Collections.Generic;

namespace GrouponDesktop.DTOs
{
    public class Ciudad
    {
        public long id_ciudad { set; get; }
        public string descripcion { set; get; }
    }

    public class CiudadEqualityComparer : IEqualityComparer<Ciudad>
    {
        public bool Equals(Ciudad x, Ciudad y)
        {
            return x.id_ciudad == y.id_ciudad;
        }

        public int GetHashCode(Ciudad obj)
        {
            throw new NotImplementedException();
        }
    }
}
