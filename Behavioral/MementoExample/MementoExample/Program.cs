namespace MementoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            History history = new History();

            Editor editor = new Editor();
            
            editor.content = "a";
            history.push(editor.CreateState());

            editor.content = "b";
            history.push(editor.CreateState());

            editor.content = "c";
            /editor.restore(history.pop());
            
            Console.WriteLine(" output " + editor.content);
        }
    }
}
