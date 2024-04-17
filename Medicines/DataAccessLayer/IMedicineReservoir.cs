using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines.DataAccessLayer
{
    public interface IMedicineReservoir
    {
        List<Medicine> Get();
        Medicine Get(int id);
        bool Add(Medicine newMedicine);
        bool Update(Medicine newMedicine);
        bool Delete(int id);
    }
}
