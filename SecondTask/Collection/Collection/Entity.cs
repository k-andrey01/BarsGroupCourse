using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int parentId { get; set; }

        public Entity(int id, int parentId, string Name)
        {
            this.Id = id;
            this.parentId = parentId;
            this.Name = Name;
        }
    }
}
