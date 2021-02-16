using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.Mod06DLL
{
    public class Product<T> 
    {
        public T ID { get; set; }

        public string Description { get; set; }

        public void Test()
        {
            var type = ID.GetType();
        }
    }
}
