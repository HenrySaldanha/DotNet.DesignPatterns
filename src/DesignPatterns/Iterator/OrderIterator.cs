
namespace DesignPatterns.Iterator;
internal class OrderIterator<T> : IIterator
{
    private MyCollection<T> Collection;
    private int Position = -1;
    private bool OrderDesc = false;

    public OrderIterator(MyCollection<T> collection, bool orderDesc = false)
    {
        Collection = collection;
        OrderDesc = orderDesc;

        if (orderDesc)
            Position = collection.Count;
    }

    public object Current() => Collection.GetItem(Position);

    public int Key() => Position;

    public bool MoveNext()
    {
        var newPosition = Position + (OrderDesc ? -1 : 1);

        if (newPosition >= 0 && newPosition < Collection.Count)
        {
            Position = newPosition;
            return true;
        }
        return false;
    }

    public void Reset() => Position = OrderDesc ? Collection.Count - 1 : 0;
}