namespace para
{
    class SimpleStack : IStack
    {
        
        private int[] _array = new int[10];
        private int _count = 0;
        public int Array
        {
            get { return _array.Length; }
        }
        public void Clear()
        {
            int[] newArr = new int[10];
            _array = newArr;
            _count = 0;
        }

        public bool isEmpty()
        {
            if(_count == 0) 
                return false;
            else
                return true;

        }

        public int Pop()
        {
            
            int i = _array[_count];
            _array[_count] = 0;
            if(_count != 0 )
            {
                _count--;
            }
            
            return i;
        }

        public void Push(int value)
        {
            if(_array.Length > _count)
            {
                _array[_count] = value;
            } 
            else
            {
                int[] ints= new int[_count * 2];
                _array.CopyTo(ints, 0);
                _array = ints;
                _array[_count] = value;
            }
            if(_count<_array.Length-1)
                _count++;
        }

        public int Size()
        {
            return _count;
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in _array)
            {
                s += item + " ";

            }
            return $"Элементы стека: {s}";
        }

        public static IStack CreateStack(IStack stack)
        {
            IStack stack1 = stack;
            IStack st = new SimpleStack();

            for (int i = 0; i < stack1.Array; i++)
            {
                st.Push(stack1.Pop());
            }
            return st;

        }
    }
}
