using System.Collections.Generic;

namespace GameDev3Library.InventorySystem
{
    public interface IInventoryManager<T>
    {
        void AddItem(string keyItemName,T item);
        void RemoveItem(string keyItemName);
        
        void IncreaseItemAmount(string keyItemName,int amount);
        void DecreaseItemAmount(string keyItemName,int amount);
        
        int GetItemAmount(string keyItemName);
        T GetItem(string key);

        List<string> ListItemNames();
        List<T> ListItems();
    }
}