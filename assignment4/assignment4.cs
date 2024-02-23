

/*
 * Practice working with Generics
 * code for question 1:
 */
class MyStack<T>
{
    private List<T> list;

    public MyStack()
    {
        list = new List<T>();
    }

    public int Count()
    {
        return list.Count;
    }

    public T Pop()
    {
        if (list.Count == 0)
            throw new Exception("The list is empty.");
        T result = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return result;
    }

    public void Push(T element)
    {
        list.Add(element);
    }
}


/*
 * code for question 2:
 */
class MyList<T>
{
    private List<T> list;

    public MyList()
    {
        list = new List<T>();
    }
    
    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        if (list.Count == 0)
            throw new Exception("The list is empty.");
        if (index >= list.Count())
            throw new Exception("The index is out of bounds.");
        T result = list[index];
        list.RemoveAt(index);
        return result;
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    public void Clear()
    {
        list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        list.RemoveAt(index);
    }

    public T Find(int index)
    {   
        if (list.Count == 0)
            throw new Exception("The list is empty.");
        if (index >= list.Count())
            throw new Exception("The index is out of bounds.");
        return list[index];
    }
}

/*
 * code for question 3:
 */
public interface IRepository<T> where T : class
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}


public class GenericRepository : IRepository<Entity>
{
    private List<Entity> list = new List<Entity>();
    public void Add(Entity item)
    {
        if (GetById(item.Id) == null)
        {
            list.Add(item);
        }
        else 
            Console.WriteLine("Item id already exists...");
    }
    public void Remove(Entity item)
    {
        list.Remove(item);
    }

    public void Save()
    {
        return;
    }

    public IEnumerable<Entity> GetAll()
    {
        return list;
    }

    public Entity GetById(int id)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Id == id)
            {
                return list[i];
            }
        }

        return null;
    }


}

public class Entity
{
    public string Name
    {
        get;
        set;
    }

    public int Id
    {
        get;
        set;
    }

    public Entity(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

