using System;
using System.Collections.Generic;

namespace Packing.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Id { get;}
        public static int currentId {get; set;} = 0;
        private static List<Item> _packingList = new List<Item> { };
       public Item(string name, string description, string status)
       {
        Name = name;
        Description = description;
        Status = status;
        _packingList.Add(this);
        currentId +=1;
        Id = currentId; 
       }

       public static List<Item> GetAll(){
        return _packingList;
       }
       public static void ClearAll()
       {
        _packingList.Clear();
       }
    
        public static Item Findthingy(int searchID){
            return _packingList.Find(x=> x.Id == searchID);
        }

        public static void Delete(Item foundItem)
        {
            _packingList.Remove(foundItem);
        }

    }
}