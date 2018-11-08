using System;
using System.Collections;
using System.Collections.Generic;
namespace testList
{
    public class ListTest<T> : IEnumerable
    {
        public T value;
        public ListTest<T> next;
        private ListTest<T> _current = null;
        public ListTest(T value)
        {
            this.value = value;
        }
        public void Add(T value) 
        {
            if (_current == null) 
            {
                next = new ListTest<T>(value);
                _current = next;
            }
            else 
            {
                _current.next = new ListTest<T>(value);
                _current = _current.next;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
		public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        private class Enumerator : IEnumerator
        {
            public Enumerator(ListTest<T> list)
            {
                this.list = list;
            }
            ListTest<T> list;
            public object Current { get; private set; }

            public bool MoveNext()
            {
                if (list == null) return false;

                Current = list.value;
                list = list.next;
                return true;
            }

            public void Reset()
            {
                list = null;
            }
        }
	}
}
