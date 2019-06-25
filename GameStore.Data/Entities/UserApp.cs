using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Data.Entities
{
    public class UserApp
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long AppId { get; set; }
        public App App { get; set; }
    }
}
