using System;

namespace TaskItems
{
    public class AgendaItem
    {
        private string itemName, itemDescription, itemType;
        private int itemId, itemImportance;

	    public AgendaItem()
	    {

	    }

        public void setItem(string itemName, string itemDescriptionm, string itemType, int itemId, int itemImportance)
        {
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.itemType = itemType;
            this.itemId = itemId;
            this.itemImportance = itemImportance;
        }

        public bool uptateItem()
        {

        }

        public bool deleteItem()
        {

        }

        public AgendaItem getFromDb(int id)
        {

        }

        public AgendaItem[] getAllFromDb()
        {

        }

    }
}