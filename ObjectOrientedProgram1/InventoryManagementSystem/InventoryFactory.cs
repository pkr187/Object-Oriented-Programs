using Newtonsoft.Json;
using ObjectOrientedProgram1.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram1.InventoryManagementSystem
{
    public class InventoryFactory
    {
        InventoryManagement inventory = new InventoryManagement();
        public void ReadJsonFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                this.inventory = JsonConvert.DeserializeObject<InventoryManagement>(json);
                Display(this.inventory.RiceList, "RiceList");
                Display(this.inventory.WheatList, "WheatList");
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }
        public void AddInventory(string inventoryName, InventoryDetails details)
        {
            if (inventoryName == "RiceList")
            {
                this.inventory.RiceList.Add(details);
                Display(this.inventory.RiceList, "RiceList");
            }
            if (inventoryName == "WheatList")
            {
                this.inventory.WheatList.Add(details);
                Display(this.inventory.WheatList, "WheatList");
            }
            if (inventoryName == "PulsesList")
            {
                this.inventory.PulsesList.Add(details);
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }
        public void DeleteInventory(string inventoryName, string inventoryDetailsName)
        {
            if (inventoryName == "RiceList")
            {
                foreach (var data in this.inventory.RiceList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.RiceList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exist");
            }
            if (inventoryName == "WheatList")
            {
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.WheatList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exists");
            }
            if (inventoryName == "PulsesList")
            {
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.PulsesList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exists");
            }

        }
        public void EditInventory(string inventoryName, string inventoryDetailName)
        {
            Console.WriteLine("Enter RiceList, WheatList, PulsesList to Edit:");
            string InventoryDetail = Console.ReadLine();

            if (inventoryName == "RiceList")
            {
                Console.WriteLine("enter the Rice name to edit: ");
                string RiceList = Console.ReadLine();
                foreach (var data in this.inventory.RiceList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("To Edit RiceList Enter 1.Weight 2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Choose Valid Option");
                                break;
                        }
                    }
                }
            }
            if (inventoryName == "WheatList")
            {
                Console.WriteLine("enter Wheat list to edit");
                string Name = Console.ReadLine();
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("To Edit WheatList Enter 1.Weight 2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Choose Valid Option");
                                break;
                        }
                    }
                }
            }
            if (inventoryName == "PulsesList")
            {
                Console.WriteLine("enter the Pulses name which you want to edit: ");
                string Name = Console.ReadLine();
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("To Edit PulsesList Enter 1.Weight 2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Choose Valid Option");
                                break;
                        }
                    }
                }
                Console.WriteLine("Inventory does not exists");
            }
        }
        public void WriteToJson(string filepath)
        {
            var json = JsonConvert.SerializeObject(this.inventory);
            File.WriteAllText(filepath, json);
        }
        public void Display(List<InventoryDetails> list, string inventoryName)
        {
            Console.WriteLine("Inventory is:" + inventoryName);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "price");
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + "\t" + data.weight + "\t" + data.price);
            }
        }
    }
}