using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class Stack<T>
    {
        private List<T> _stack = new List<T>();

        public void Push(T item)
        {
            _stack.Add(item);
        } 
        public T Pop()
        {
            T poppedItem = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return poppedItem;
        }
        public T Peek()
        {
          

            return _stack[_stack.Count - 1];
        }

        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }
    }
}
