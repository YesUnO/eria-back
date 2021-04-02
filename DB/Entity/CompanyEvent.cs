using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eria_back.DB.Entity
{
    public class CompanyEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
