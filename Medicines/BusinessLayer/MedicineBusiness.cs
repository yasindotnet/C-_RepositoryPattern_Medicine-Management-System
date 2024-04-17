using Medicines.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines.BusinessLayer
{
    public class MedicineBusiness
    {
        IMedicineReservoir reservoir;
        public MedicineBusiness(IMedicineReservoir myreservoir)
        {
            reservoir = myreservoir;
        }
        public List<Medicine> Get()
        {
            return reservoir.Get();
        }
        public Medicine Get(int id)
        {
            return reservoir.Get(id);
        }
        public bool Add(Medicine newMedicine)
        {
            return reservoir.Add(newMedicine);
        }
        public bool Update(Medicine newMedicine)
        {
            return reservoir.Update(newMedicine);
        }
        public bool Delete(int id)
        {
            return reservoir.Delete(id);
        }
    }
}
