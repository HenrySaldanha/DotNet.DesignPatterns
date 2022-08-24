using System.Collections;

namespace DesignPatterns.Iterator;
internal interface IIteratorAggregate : IEnumerable
{
    public IEnumerator GetEnumerator();
}