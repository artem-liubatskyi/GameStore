using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Data.Entities
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<UserApp> Apps { get; set; }
    }
}
