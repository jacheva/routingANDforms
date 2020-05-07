using System;
using System.Collections.Generic;
using System.Text;

namespace Share.DTOs
{
    public class PaginatedResponse<T>
    {
        public T Response { get; set; }
        public int  TotalAmountPages { get; set; }

    }
}
