using System.Collections;
using System.Collections.Generic;

namespace Option_Object
{
    class Option<T> : IEnumerable<T>
    {
        private IEnumerable<T> _contents { get; }
        private Option(IEnumerable<T> contents)
        {
            _contents = contents;
        }
        public static Option<T> Some(T value) => new Option<T>(new T[] { value });
        public static Option<T> None() => new Option<T>(new T[0] { });
        public IEnumerator<T> GetEnumerator() => this._contents.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
