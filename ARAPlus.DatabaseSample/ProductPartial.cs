using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.DatabaseSample
{
    partial class Product
    {
        public bool CheckIsAuthorized()
        {
            return ProductName=="Hello";
        }
    }
}
