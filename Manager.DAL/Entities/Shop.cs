using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.DAL.Entities
{
    public class Shop
    {
        public Shop()
        {
            JobHistories = new HashSet<JobHistory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
    }
}
