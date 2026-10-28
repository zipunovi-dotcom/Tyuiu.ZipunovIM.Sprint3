using Tyuiu.ZipunovIM.Sprint3.Task4.V10.Lib;

namespace Tyuiu.ZipunovIM.Sprint3.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Зипунов И. М. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Зипунов Игорь Максимович  | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("На отрезке, где x принимает значения от -5 до 5,вычислить значение функции*");
            Console.WriteLine("*y=(sin(x)-x)/x\r\n\r\nПри х = 0                                          *");
            Console.WriteLine("* пропустить значение Полученные значения перемножать.                    *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите стартовое значение: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(y, z));

            Console.ReadKey();
        }
    }
}