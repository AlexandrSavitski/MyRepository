using System;
using System.Collections.Generic;
using System.Text;

namespace HW._12
{
    class MotorcycleRepository : IRepository
    {
        List<Motorcycle> moto = new List<Motorcycle>(3);
        moto.Add(new Motorcycle() { Id = 1, Name = "Honda", Model = "CRB", Value = 250, Year = 2003, Odometr = 8000 });
        moto.Add(new Motorcycle() { Id = 2, Name = "Suzuki", Model = "ATV", Value = 50, Year = 2012, Odometr = 7000 });
        moto.Add(new Motorcycle() { Id = 3, Name = "Minsk", Model = "R250", Value = 100, Year = 2016, Odometr = 1200 });

        public Motorcycle GetMotorcycleByID(int id)
        {
            Console.Write("Введите ID: ");
            Int32.TryParse(Console.ReadLine(), out id);
            return moto.Find(id);
        }

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return moto;
        }

        public void CreateMotorcycle(Motorcycle item)
        {
            throw new NotImplementedException();
        }

        public void UpdateMotorcycle(Motorcycle item)
        {
            throw new NotImplementedException();
        }

        public void DeleteMotorcycle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
