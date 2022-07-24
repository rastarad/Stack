using StackNamespace;

Stack stack = new Stack();
var input = "";
MustBe.StartInfo();
while (input != "end")
{
    input = Console.ReadLine();
    if(input == "push")
    {
        Console.Write("Type element: ");
        string input2 = Console.ReadLine();
        stack.Push(input2);
        Console.Clear();
        MustBe.StartInfo();
        Console.WriteLine("You have added an object to the stack");
    }
    else if(input == "pop")
    {
        var stackObj = stack.Pop();
        Console.Clear();
        MustBe.StartInfo();
        if(stackObj == "none element")
        {
            Console.WriteLine("You are trying to remove object from empty stack");
        }
        Console.WriteLine($"You have removed {stackObj} from the stack");
    }
    else if(input == "clear")
    {
        stack.Clear();
        Console.Clear();
        MustBe.StartInfo();
        Console.WriteLine("You have removed all objects from the stack");
    }
    else if(input == "show")
    {
        Console.Clear();
        MustBe.StartInfo();
        stack.Show();
    }
    else
    {
        Console.Clear();
        MustBe.StartInfo();
        Console.WriteLine("Wrong typing");
    }
}
Console.WriteLine("Thanks for using");

