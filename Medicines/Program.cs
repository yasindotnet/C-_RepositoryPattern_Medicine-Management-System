using Medicines.BusinessLayer;
using Medicines.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicineBusiness medicineBusiness = new MedicineBusiness(new MedicineReservoir());
            bool isIf = true;
            while (isIf)
            {
                try
                {
                    Console.WriteLine("Press:\n------\n 'l' for MedicineList  'i' for Insert 'u' for Update " +
                        "'d' for Delete 'f' for find a Medicine 'c' for Clear 'e' for Exit\n Insert Your choise");
                    string press = Console.ReadLine();
                    if (press == "l")
                    {
                        List<Medicine> medicinelist = medicineBusiness.Get();
                        Console.WriteLine("List Of Medicine :");
                        Console.WriteLine("----------------");
                        Console.WriteLine("ID |   MedicineName    |   Type");
                        Console.WriteLine("--- ------------------- -------");
                        foreach (Medicine medicine in medicinelist)
                        {
                            Console.WriteLine(medicine.MedicineID + "  |  " + medicine.MedicineName + "   |   " + medicine.MedicineType);
                        }
                    }
                    else if (press == "f")
                    {
                        Console.WriteLine("Input a id to find a Medicine");
                        int id = int.Parse(Console.ReadLine());
                        Medicine aMedicine = medicineBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aMedicine.MedicineID + ". " + aMedicine.MedicineName + " -- " + aMedicine.MedicineType);
                    }
                    else if (press == "i")
                    {
                        Console.WriteLine("Input a MedicineID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a MedicineName:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input MedicineType:");
                        string type = Console.ReadLine();
                        Medicine aMedicine = new Medicine();
                        aMedicine.MedicineID = id;
                        aMedicine.MedicineName = name;
                        aMedicine.MedicineType = type;
                        bool isExecuted = medicineBusiness.Add(aMedicine);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added Succesfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Add");
                        }
                    }
                    else if (press == "u")
                    {
                        Console.WriteLine("Input a MedicineID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a MedicineName:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input MedicineType:");
                        string type = Console.ReadLine();
                        Medicine aMedicine = new Medicine();
                        aMedicine.MedicineID = id;
                        aMedicine.MedicineName = name;
                        aMedicine.MedicineType = type;
                        bool isExecuted = medicineBusiness.Update(aMedicine);
                        if (isExecuted)
                        {
                            Console.WriteLine("Update Succesfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Add");
                        }
                    }
                    else if (press == "d")
                    {
                        Console.WriteLine("Input a MedicineID:");
                        int id = int.Parse(Console.ReadLine());
                        bool isExecuted = medicineBusiness.Delete(id);
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted Succesfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Add");
                        }
                    }
                    else if (press == "c")
                    {
                        Console.Clear();
                    }
                    else if (press == "e")
                    {
                        isIf = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error :" + ex.Message);
                }
            }
        }
    }
}
