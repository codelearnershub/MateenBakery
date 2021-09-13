using BakeryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Interface
{
    public interface ISalesRepository
    {
        public Sales Add(Sales sales);

        public Sales FindById(int salesId);

        public Sales Update(Sales sales);

        public void Delete(int salesId);
    }
}
