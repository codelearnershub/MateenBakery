using BakeryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Interface
{
    public interface ISalesItemRepository
    {
        public SalesItem Add(SalesItem salesItem);

        public SalesItem FindById(int salesItemId);

        public SalesItem Update(SalesItem salesItem);

        public void Delete(int salesItemId);
    }
}
