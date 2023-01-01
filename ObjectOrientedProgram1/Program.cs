using ObjectOrientedProgram1.InventoryManagement;
using ObjectOrientedProgram1.InventoryManagementSystem;

namespace ObjectOrientedProgram1
{
    internal class Program
    {
        //given inventory path to json
        const string INVENTORY_DATA_FILE_PATH = @"C:\Object Oriented Practice Problem\ObjectOrientedProgram1\InventoryManagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Object Oriented Practice Problem\ObjectOrientedProgram1\InventoryManagementSystem\InventoryDetails.json";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.InventoryManagement\n 2.InventoryManagementSystem");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        InventoryFactory inventoryFactory = new InventoryFactory();
                        inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                        InventoryDetails details = new InventoryDetails()
                        {
                            Name = "Basmati",
                            weight = 10,
                            price = 20,
                        };
                        //Add Inventory
                        inventoryFactory.AddInventory("RiceList", details);
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        //Delete Inventory
                        inventoryFactory.DeleteInventory("RiceList", "Basmati");
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        //Edit Inventory
                        inventoryFactory.EditInventory("RiceList", "Basmati");
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}

