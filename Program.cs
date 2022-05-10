
namespace LinkedList
{
    public class program
    {
        public static void Main(String[] args)
        {
            // create Object of Implementing class
            StackByLL obj = new StackByLL();

            // insert Stack value
            obj.push(56);
            obj.push(30);
            obj.push(70);
            obj.IsEmpty();
        }
    }
}