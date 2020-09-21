namespace _1_Generics
{
    public interface IMyCollection<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }
        void WriteElement(T element);
        T ReadElement();
        T CheckElement();
        void DisplayAll();
        
        
    }
}