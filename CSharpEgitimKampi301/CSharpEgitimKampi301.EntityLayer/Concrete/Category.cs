using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}


/*
 Field-Variable-Property

 int x; ----> Field
public x {get; set;} ----> Property

void method()
{
  int x; ----> Variable
}

 */