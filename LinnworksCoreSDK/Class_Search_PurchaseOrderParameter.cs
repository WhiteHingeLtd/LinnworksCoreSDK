using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Search_PurchaseOrderParameter
    {
        public DateTime? DateFrom;
        public DateTime? DateTo;
        public PurchaseOrderStatus? Status;
        public string ReferenceLike;
        public int EntriesPerPage;
        public int PageNumber;
        public List<Guid> Location;
        public List<Guid> Supplier;
    }
}