using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Data.Entities
{
    public class App : IEntity
    {
        public long Id { get; set; }
        public long DeveloperId { get; set; }
        public Developer Developer { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }
        public int DownloadCount { get; set; }

        public IEnumerable<AppCategorie> Categories { get; set; }

        public long TypeId { get; set; }
        public AppType Type { get; set; }
    }
}
