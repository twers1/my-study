using System;
namespace para
{
    interface IStack
    {
        int Array { get;} 
        void Push(int value);
        int Pop();
        bool isEmpty();
        int Size();
        void Clear();
    }
}
