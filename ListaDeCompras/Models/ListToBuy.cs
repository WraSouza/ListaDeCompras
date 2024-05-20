using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Models
{
    public class ListToBuy
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
        public List<User>? Users { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
