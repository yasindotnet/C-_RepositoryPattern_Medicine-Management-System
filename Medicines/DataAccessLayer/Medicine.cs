using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines.DataAccessLayer
{
    public class Medicine
    {
        public int MedicineID;
        public string MedicineName;
        public string MedicineType;
        public Medicine()
        {

        }
        public Medicine(int id, string medicineName, string type)
        {
            MedicineID = id;
            MedicineName = medicineName;
            MedicineType = type;
        }
    }
}
