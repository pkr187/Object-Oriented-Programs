using ObjectOrientedPrograms.InventoryManagement;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        //given inventory path to json
        const string INVENTORY_DATA_FILE_PATH = @"C:\Object Oriented Practice Problem\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.InventoryManagement");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}
