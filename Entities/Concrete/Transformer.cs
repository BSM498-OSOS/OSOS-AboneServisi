using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Transformer : IEntity
    {
        public Guid Id { get;  set; }
        public String City { get; set; }
        public String District  { get; set; }
        public String Neighbourhood { get; set; }

    }
}
