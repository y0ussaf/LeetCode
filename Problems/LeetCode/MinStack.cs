using System.Collections;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class MinStack
    {
        private Stack<KeyValuePair<int,int>> _stack = new Stack<KeyValuePair<int, int>>();
           public MinStack() {
            
        }
        public void Push(int x)
        {
            int min;
            if (_stack.Count == 0)
            {
                min = x;
                
            }
            else
            {
               
               min = _stack.Peek().Value;
               min = x < min ? x : min;
            }
            KeyValuePair<int,int> a = new KeyValuePair<int, int>(x,min);
            _stack.Push(a);
 
        }
    
        public void Pop()
        {
            _stack.Pop();
         }
    
        public int Top()
        {
            return _stack.Peek().Key;
        }
    
        public int GetMin()
        {
            return  _stack.Peek().Value;
        }
    }
}