namespace StackNamespace
{
    public class Stack
    {
        private static List<object> list = new List<object>();
        public void Push(string obj)
        {
                list.Add(obj);
        }
        public object Pop()
        {
            if (list.Count == 0)
            { 
                return "none element";
            }
            else
            {
                var lastElement = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return lastElement;
            }
        }
        public void Clear()
        {
            list.Clear();
        }
        public void Show()
        {
            Console.WriteLine("Objects in stack: ");
            foreach(object e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
