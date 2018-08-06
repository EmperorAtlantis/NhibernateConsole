using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime CreateTime { get; set; }
    }
}
