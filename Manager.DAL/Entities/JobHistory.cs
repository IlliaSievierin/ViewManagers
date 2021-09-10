using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.DAL.Entities
{
    public class JobHistory
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
