using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Abstraction
{
    public class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }

        public Entity()
        {
            Id = default;
        }

        public Entity(TId id)
        {
            Id = id;
        }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
