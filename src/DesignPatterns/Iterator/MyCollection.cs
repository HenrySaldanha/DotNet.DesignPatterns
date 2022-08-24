using System.Collections;

namespace DesignPatterns.Iterator;
internal class MyCollection<T> : IIteratorAggregate
{
    public List<T> Collection;

    public bool OrderDesc;
    public int Count
    {
        get { return Collection.Count; }
    }

    public MyCollection()
    {
        Collection = new();
        OrderDesc = false;
    }

    public void ReverseDirection() => OrderDesc = !OrderDesc;
    public List<T> GetItems() => Collection;
    public T GetItem(int i) => Collection[i];
    public void AddItem(T item) => Collection.Add(item);
    public IEnumerator GetEnumerator() => new OrderIterator<T>(this, OrderDesc);
}
