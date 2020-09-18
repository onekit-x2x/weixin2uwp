using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace cn.onekit.js.core
{
    public abstract class Iterator<I> :IIterator<Iterator<I>.Item<I>> {


        public class Item<I>
        {

            private I _value;
            private bool _done;

            public Item(I value, bool done)
            {
                _value = value;
                _done = done;
            }


            public string ToString()
            {
                return string.Format("Object { value: {0}, done: {1} }", getValue(), getDone());
            }

            public I getValue()
            {
                return _value;
            }

            public bool getDone()
            {
                return _done;
            }

        }
        ///////////////////////////////

        public Iterator(IIterator<object> iterator)
        {
            _iterator = iterator;
        }
        public abstract I getValue(Object value);
        private IIterator<object> _iterator;

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public uint GetMany([LengthIs(0)] core.Iterator<I>.Item<I>[] items)
        {
            throw new NotImplementedException();
        }

        public Iterator<I>.Item<I> Current
        {
            get
            {
                return (Item<I>)_iterator.Current;
            }
        }

        public bool HasCurrent
        {
            get{
                return _iterator.HasCurrent;
            }
        }

        ///////////////////////////////






    }

}
