using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamYankeeBLL.DTO
{
    public class UnitDesciption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UnitDesciption(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //TODO: UnitCost

    }
}
