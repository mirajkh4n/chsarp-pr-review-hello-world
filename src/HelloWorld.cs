// This is a .NET 5 (and earlier) console app template
// (See https://aka.ms/new-console-template for more information)

using NLog;
using NLog.Targets;
using System.Text;

namespace MyApp
{

    internal class HelloWorld
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Logger.Info("Starting program ...");
            string LOGDIR = Environment.GetEnvironmentVariable("LOGDIR");
            Logger.Debug("LOGDIR is set to {0}", LOGDIR);

            // Just for testing:
            // Logger.Trace("Trace");
            // Logger.Debug("Debug");
            // Logger.Info("Info");
            // Logger.Warn("Warn");
            // Logger.Error("Error");
            // Logger.Fatal("Fatal");


            Console.WriteLine("Hello, World!");

            double x = 1.234;
            double y = 4.321;
            Logger.Debug("calling Library.MyMath.Add(x, y) with x={0} and y={1} ...", x, y);
            double sum = Library.MyMath.Add(x, y);
            Logger.Debug("calling Library.MyMath.Multiply(x, y) with x={0} and y={1} ...", x, y);
            double prod = Library.MyMath.Multiply(x, y);
            Console.WriteLine(String.Format("{0} plus {1} makes {2}", x, y, sum));
            Console.WriteLine(String.Format("{0} times {1} makes {2}", x, y, prod));


            Library.DataStore<int, string> myData = new Library.DataStore<int, string>();
            for (int i = 0; i < 100; i++)
            {
                string text = string.Format("This is element {0}.", i);
                myData.Add(i, text);
            }

            PrintElement(myData, 42);
            PrintElement(myData, 100);
            PrintElement(myData, 101);
            PrintElement(myData, 102);

            Logger.Info("Terminating program ...");
        }
        public static void PrintElement(Library.DataStore<int, string> Store, int index)
        {
            Library.Pair<int, string>? element = Store.GetElementByIndex(index);
            if (element is Library.Pair<int, string> valueOfElment)
            {
                Logger.Trace("idx {0}: found element", index);
                Console.WriteLine(String.Format("idx {0}: key {1}, value {2}", index,
                    element.GetKey(), element.GetValue()));
            }
            else
            {
                Logger.Warn("idx {0}: no such element in DataStore", index);
                Console.WriteLine(String.Format("idx {0}: no such element in DataStore", index));

                            
                            class Program
                            {
                                static void Main()
                                {
                                    int[] numbers = { 5, 2, 9, 1, 5, 6 };
                                    SortArray(numbers);

                                    Console.WriteLine("Sorted array:");
                                    foreach (var num in numbers)
                                    {
                                        Console.Write(num + " ");
                                    }
                                }

                                static void SortArray(int[] arr)
                                {
                                    for (int i = 0; i < arr.Length; i++)
                                    {
                                        for (int j = i + 1; j < arr.Length; j++)
                                        {
                                            if (arr[j] < arr[i])
                                            {
                                                int temp = arr[j];
                                                arr[i] = arr[j];
                                                arr[j] = temp;
                                            }
                                        }
                                    }
                                }
                            }

            }

            void DrawCircle(Graphics g, int x, int y, int radius, Color color, float thickness)
{
    Pen pen = new Pen(color, thickness);
    g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
    pen.Dispose();
}

void FillCircle(Graphics g, int x, int y, int radius, Color fillColor)
{
    Brush brush = new SolidBrush(fillColor);
    g.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
    brush.Dispose();
}

void DrawCircleWithLabel(Graphics g, int x, int y, int radius, string label, Font font, Color textColor)
{
    DrawCircle(g, x, y, radius, Color.Black, 2);
    Brush brush = new SolidBrush(textColor);
    SizeF textSize = g.MeasureString(label, font);
    g.DrawString(label, font, brush, x - textSize.Width / 2, y - textSize.Height / 2);
    brush.Dispose();
}
        }

    } // class HelloWorld

} // namespace MyApp
