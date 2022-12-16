namespace DataStructure
{

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertNode(2, 30);
            list.Display();
        }
    }
}
