using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines.DataAccessLayer
{
    public class MedicineReservoir : IMedicineReservoir
    {
        List<Medicine> listMedicine = new List<Medicine>()
        {
            new Medicine(1,"Napa","Tablet"),
            new Medicine(2,"Ace","Capsule"),
            new Medicine(3,"Bislol","Capsule"),
            new Medicine(4,"Clob","Tablet")
        };
        public List<Medicine> Get()
        {
            return listMedicine.OrderBy(x => x.MedicineName).ToList();
        }
        public Medicine Get(int id)
        {
            Medicine oMedicine = listMedicine.Where(x => x.MedicineID == id).FirstOrDefault();
            return oMedicine;
        }
        public bool Add(Medicine newMedicine)
        {
            listMedicine.Add(newMedicine);
            return true;
        }
        public bool Update(Medicine newMedicine)
        {
            bool isExecuted = false;
            Medicine oMedicine = listMedicine.Where(x => x.MedicineID == newMedicine.MedicineID).FirstOrDefault();
            if (oMedicine != null)
            {
                listMedicine.Remove(oMedicine);
                listMedicine.Add(newMedicine);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int id)
        {
            bool isExecuted = false;
            Medicine oMedicine = listMedicine.Where(x => x.MedicineID == id).FirstOrDefault();
            if (oMedicine != null)
            {
                listMedicine.Remove(oMedicine);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
