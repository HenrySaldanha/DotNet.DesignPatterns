using System.Collections;

namespace DesignPatterns.Iterator;
internal interface IIterator : IEnumerator
{
    object IEnumerator.Current => Current();
    public int Key();
    public object Current();
    public bool MoveNext();
    public void Reset();
}