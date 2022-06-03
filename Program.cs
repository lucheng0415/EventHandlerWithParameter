using System;

namespace EventHandlerWithParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press A ");
            var key = Console.ReadLine();
            if (key == "a")
            {
                KeyPressed();
            }
        }

        static void KeyPressed()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
            {
                Console.WriteLine($"you clicked a button {args.Name}");
            };
            button.OnClick();
        }
    }

    public class Button
    {
        public EventHandler<MyArgs> ClickEvent;
        public void OnClick()
        {
            MyArgs myArgs = new MyArgs();
            myArgs.Name = "Cheng";
            ClickEvent.Invoke(this, myArgs);
        }
    }
    public class MyArgs : EventArgs
    {
        public string Name { get; set; }
    }
    
}
