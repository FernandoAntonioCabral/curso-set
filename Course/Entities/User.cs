using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class User
    {
        public string Name { get; set; }
        public int UniCod { get; set; }

        public override int GetHashCode()
        {
            return UniCod.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is User)) {
                return false;
            }
            User other = obj as User;
            return UniCod.Equals(other.UniCod);
        }
    }
}
