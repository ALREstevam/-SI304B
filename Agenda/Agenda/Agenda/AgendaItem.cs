using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Database;

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
            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();
            if(contr.dbExecuteQuery(toSqlDeleteString(), conn))
            {
                return true;
            }
            return false;
        }

        public AgendaItem getFromDb(int id)
        {
            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM AgendaItem", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            AgendaItem AgdItem = new AgendaItem();

            dr.Read();

            AgdItem.itemId = Convert.ToInt32(dr["id"]);
            AgdItem.itemName = dr["name"].ToString();
            AgdItem.itemDescription = dr["description"].ToString();
            AgdItem.itemImportance = Convert.ToInt32(dr["importance"]);
            AgdItem.itemType = Convert.ToInt32(dr["type"]);
            
            contr.dbDisconnect(conn);
            return AgdItem;
        }

        public List<AgendaItem> getAllFromDb()
        {
            DatabaseController contr = new DatabaseController("database.db");
            SQLiteConnection conn = contr.dbConnect();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM AgendaItem ORDER BY importance DESC", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            List<AgendaItem> lista = new List<AgendaItem>();

            while (dr.Read())
            {
                lista.Add(new AgendaItem
                {
                    itemId          =   Convert.ToInt32(dr["id"]),
                    itemName        =   dr["name"].ToString(),
                    itemDescription =   dr["description"].ToString(),
                    itemImportance  =   Convert.ToInt32(dr["importance"]),
                    itemType        =   Convert.ToInt32(dr["type"]),
                });
            }
            contr.dbDisconnect(conn);
            return lista;
        }

        public string toSqlInsertString()
        {

            return "INSERT INTO AgendaItem(name, description, type, importance) VALUES("
                + "'"+this.itemName + "',"
                + "'"+this.itemDescription + "',"
                + this.itemType + "," 
                + this.itemImportance
                +")";
        }

        public string toSqlUpdateString()
        {
            return "UPDATE AgendaItem SET "
                + "name = '" + this.itemName 
                + "', description = '" + this.itemDescription 
                + "', type =" + this.itemType 
                + ", importance = " + this.itemImportance + 
                " WHERE id = "+this.itemId;
        }

        public string toSqlDeleteString()
        {
            return "DELETE FROM AgendaItem WHERE id = " + this.itemId + ";";
        }

    }
}