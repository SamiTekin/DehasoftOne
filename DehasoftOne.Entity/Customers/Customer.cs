using DehasoftOne.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DehasoftOne.Entity.Customer;

public class Customer:BaseEntity
{
    public string Name { get; set; }
    public string Surname {get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string TCKN { get; set; }
}
