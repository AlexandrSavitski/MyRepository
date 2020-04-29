using System;
using System.Collections.Generic;
using System.Text;

namespace HW._12
{
    interface IRepository
    {
        Motorcycle GetMotorcycleByID(int id);
        IEnumerable<Motorcycle> GetMotorcycles();
        void CreateMotorcycle(Motorcycle item);
        void UpdateMotorcycle(Motorcycle item);
        void DeleteMotorcycle(int id);
    }
}
