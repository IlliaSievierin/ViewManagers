using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.DAL.Entities
{
    public class Manager
    {
        public Manager()
        {
            JobHistories = new HashSet<JobHistory>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmployee { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
    }
}
