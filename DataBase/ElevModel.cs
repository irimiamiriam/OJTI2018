using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJTI2018.DataBase
{
    public class ElevModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ElevModel(int id , string name) 
        { 
            Id= id;
            Name= name;
        }
    }
}
