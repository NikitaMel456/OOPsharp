using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lab_4Sharp
{
    public class CollectionType<T> : IList, ICollection
    {
        T obj;
        private const int N = 9;
        private int count = 0;

        public CollectionType() { }
        public string s;
        public ArrayList _arraylist = new ArrayList();

        public int length;
       
        public bool IsReadOnly
        {
            get
            {
                return ((IList)_arraylist).IsReadOnly;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return ((IList)_arraylist).IsFixedSize;
            }
        }

        public int Count
        {
            get
            {
                return ((IList)_arraylist).Count;
            }
        }

        public object SyncRoot
        {
            get
            {
                return ((IList)_arraylist).SyncRoot;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return ((IList)_arraylist).IsSynchronized;
            }
        }

        public object this[int index]
        {
            get
            {
                return ((IList)_arraylist)[index];
            }

            set
            {
                ((IList)_arraylist)[index] = value;
            }
        }

        public CollectionType(T obj) { this.obj = obj; }

        public int Add(object value)
        {
            return ((IList)_arraylist).Add(value);
        }

        public bool Contains(object value)
        {
            return ((IList)_arraylist).Contains(value);
        }

        public void Clear()
        {
            ((IList)_arraylist).Clear();
        }

        public int IndexOf(object value)
        {
            return ((IList)_arraylist).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            ((IList)_arraylist).Insert(index, value);
        }

        public void Remove(object value)
        {
            ((IList)_arraylist).Remove(value);
        }

        public void RemoveAt(int index)
        {
            ((IList)_arraylist).RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            ((IList)_arraylist).CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IList)_arraylist).GetEnumerator();
        }
       

        public void Type() { Console.WriteLine("Object's type-{0}", typeof(T)); }
        public int Add(ArrayList value)
        {
            if (count < 9)
            {
                _arraylist[count] = value;
                count++;
                return 0;
            }
            else throw new IndexOutOfRangeException();
        }
       
      


        public object GetN(int N)
        {
            return _arraylist.ToArray().ElementAt(N);

        }

        public int CountN(int N)
        {
            int num = 0;
            for (int i = 0; i < this._arraylist.Count; i++)
                if (_arraylist.ToArray().ElementAt(i).ToString().Length == N) { num++; }
            return num;
        }
        public void SortByL()
        {
            //  _arraylist.Sort();

            int len = _arraylist.ToArray().Min().ToString().Length;
            //for (int i = 0; i < this._arraylist.Count; i++)
            //{
            IEnumerable<object> lens = _arraylist.ToArray().OrderBy(n=> len);
            foreach (object _ara in lens)
            {
                Console.WriteLine(_ara);
            }
            
        }
        public void ElemN(int N)
        {
            IEnumerable<object> el = _arraylist.ToArray().Select(s => _arraylist.ToArray().ElementAt(N));
         
            foreach (object s in el)
            {
                Console.WriteLine(s);
                break;
            }
        }
 

    }
}

