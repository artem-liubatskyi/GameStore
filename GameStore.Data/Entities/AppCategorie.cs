using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Data.Entities
{
    public class AppCategorie
    {
        public long AppId { get; set; }
        public App App { get; set; }

        public long CategorieId { get; set; }
        public Categorie Category { get; set; }
    }
}
