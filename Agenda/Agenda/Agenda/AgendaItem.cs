using System;

namespace TaskItems
{
    public class AgendaItem
    {
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public int itemId { get; set; }
        public int itemImportance{ get; set; }
        public int itemType { get; set; }



        public AgendaItem()
	    {

	    }

        public void setItem(string itemName, string itemDescription, int itemType, int itemId, int itemImportance)
        {
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.itemType = itemType;
            this.itemId = itemId;
            this.itemImportance = itemImportance;
        }

        public bool uptateItem()
        {
            return false;
        }

        public bool deleteItem()
        {
            return false;
        }

        public void getFromDb(int id)
        {
            
        }

        /*public AgendaItem[] getAllFromDb()
        {
            
        }*/

    }
}