using System.Diagnostics;


string text = File.ReadAllText("C:\\Text1.txt");//Поис текста

var textTxt = new List<string>();

var linkedTextTxt = new LinkedList<string>();


//Проверка вставки в List<T>

var watchOne = Stopwatch.StartNew();

textTxt.Add(text);

double res1 = watchOne.Elapsed.TotalMilliseconds;

Console.WriteLine($"Вставка в List<T>: {res1}  мс");


//Проверка вставки в LinkedList<T>
var watchTwo = Stopwatch.StartNew();

linkedTextTxt.AddFirst(text);

double res2 = watchTwo.Elapsed.TotalMilliseconds;

Console.WriteLine($"Вставка в LinkedList<T>: {res2}  мс");

