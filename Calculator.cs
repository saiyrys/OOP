using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4778_OOP_Lesson5
{
    namespace Calculator
    {
        interface ICalc
        {
            event EventHandler<EventArgs> EventResult;
            float Add(int i);
            float Sub(int i);
            float Div(int i);
            float Mul(int i);
            void CancelLast();
        }

        public class Calculator : ICalc
        {
            public float result = 0;
            public event EventHandler<EventArgs> EventResult;

            public float Add(int x)
            {

                result += x;
                operation.Push(new Tuple<string, int>("+", x));
                SendResult();
                return result;
            }

            public float Sub(int x)
            {

                result -= x;
                operation.Push(new Tuple<string, int>("-", x));

                SendResult();
                return result;
            }

            public float Mul(int x)
            {

                result *= x;
                operation.Push(new Tuple<string, int>("*", x));

                SendResult();
                return result;
            }

            public float Div(int x)
            {

                result /= x;
                operation.Push(new Tuple<string, int>("/", x));

                SendResult();
                return result;
            }

            public void CancelLast()
            {
                string currentOperation = operation.Peek().Item1;
                switch (currentOperation)
                {
                    case "+":
                        result -= operation.Pop().Item2;
                        break;
                    case "-":
                        result += operation.Pop().Item2;
                        break;
                    case "*":
                        result /= operation.Pop().Item2;
                        break;
                    case "/":
                        result *= operation.Pop().Item2;
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;


                }

                SendResult();
            }

            private void SendResult()
            {
                EventResult.Invoke(this, new EventArgs());
            }
            public Stack<Tuple<string, int>> operation = new Stack<Tuple<string, int>>();


        }

        internal class Program
        {

            static void Main(string[] args)
            {
                double result = 0;

                while (true)
                {
                    Console.WriteLine("Текущий результат: " + result);
                    Console.WriteLine("Введите выражение (или 'exit' для выхода): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        break;
                    }
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }

                    try
                    {
                        result = Calculate(input, result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);
                    }
                }
            }

            static double Calculate(string input, double currentResult)
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), input);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                double result = double.Parse((string)row["expression"]);
                return result;
            }
        }
    }
}