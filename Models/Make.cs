using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CRCompras.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model_car> Models { get; set; }
        public Make(int id, string name)
        {
            Models = new Collection<Model_car>();
        }
    }
}