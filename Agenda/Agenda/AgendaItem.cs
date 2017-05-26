using System;

public class AgendaItem
{
    private string name, description, type;
    private int importance, id;


    public AgendaItem()
    {
        
    }

    public void setAgendaItem(string name, string description, string type, int importance, int id)
	{
        this.name = name;
        this.description = description;
        this.type = type;
        this.importance = importance;
        this.id = id;
	}

    public void delete()//Deletar do db (usar id)
    {

    }

    public void save()//Salvar no db
    {

    }

    public void alter()//Alterar no db (usar novos dados e id)
    {

    }

    public bool getById(int id)
    {

    }

    public AgendaItem[] readAllFromDb()//Ler do db e armazenar num array
    {
        
    }


}
