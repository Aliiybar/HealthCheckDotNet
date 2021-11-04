using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignApi.Entities
{
    public class Sign
    {
        public Guid Id { get; set; }
        public string SignName { get; set; }
        public string Location { get; set; }
    }
}
