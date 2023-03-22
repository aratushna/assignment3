namespace HashTable;

public class Dictionary
{
    private const int InitialSize = 1000000;

    private LinkedList[] _buckets = new LinkedList[InitialSize];
        
    public void Add(string key, string value)
    {
        int hash = CalculateHash(key);
        var index = hash % _buckets.Length;

        if (_buckets[index] == null)
        {
            _buckets[index] = new LinkedList();
        }
        _buckets[index].Add(new KeyValuePair(key, value));
    }

    public void Remove(string key)
    {
        int hash = CalculateHash(key);
        int index = hash % _buckets.Length;

        if (_buckets[index] != null)
        {
            _buckets[index].RemoveByKey(key);
        }        
    }

    public string Get(string key)
    {
        int hash = CalculateHash(key);
        int index = hash % _buckets.Length;

        if (_buckets[index] != null)
        {
            KeyValuePair pair = _buckets[index].GetItemWithKey(key);
            if (pair != null)
            {
                return pair.Value;
            }
        }
        return null; 
    }


    private int CalculateHash(string key)
    {
        int hash = 0;
        foreach (char c in key)
        {
            hash = hash * 13 + c;
        }

        hash = hash + key.Length;
        return hash;
    }
}