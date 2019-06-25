using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Data.Entities
{
    public class Categorie : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<AppCategorie> Apps { get; set; }
    }
}
