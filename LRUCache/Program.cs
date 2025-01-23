// See https://aka.ms/new-console-template for more information




using System.Linq;

///Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
///Implement the LRUCache class:
///LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
///int get(int key) Return the value of the key if the key exists, otherwise return -1.
///void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
///The functions get and put must each run in O(1) average time complexity.
///
public class LRUCache
{

    public int capacity;
    public LinkedList<int> deque;
    Dictionary<int, int> cache;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        this.deque = new LinkedList<int>();
        this.cache = new Dictionary<int, int>();
    }

    public int Get(int key)
    {
        if (!this.cache.ContainsKey(key))
        {
            return -1;
        }
        this.deque.Remove(key);
        this.deque.AddFirst(key);
        return this.cache[key];
    }

    public void Put(int key, int value)
    {
        if (this.cache.ContainsKey(key))
        {
            cache[key] = value;
            this.deque.Remove(key);
            this.deque.AddFirst(key);

        }
        else
        {
            if (this.deque.Count == capacity)
            {
                int lru = this.deque.Last.Value;
                this.deque.RemoveLast();
                this.cache.Remove(lru);
            }

            this.deque.AddFirst(key);
            this.cache[key] = value;
        }

    }
}