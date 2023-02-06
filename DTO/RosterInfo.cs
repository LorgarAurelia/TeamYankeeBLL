using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.DTO
{
    public class RosterBrief
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalPoints { get; set; }
        public RosterBrief(RosterDescription rosterDescription)
        {
            Id = rosterDescription.Id;
            Name = rosterDescription.Name;
            TotalPoints = rosterDescription.CurrentPoints;
        }
    }
}
