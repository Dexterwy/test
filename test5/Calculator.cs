using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    class Calculator
    {
        int _num1;
        int _num2;
        char _operator;
        int _result;
        bool isOK;
        public void Func()
        {
            while (true)
            {
                isOK = true;
                try
                {
                    Console.WriteLine("输入第一个整数");
                    _num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("输入运算符");
                    _operator = char.Parse(Console.ReadLine());
                    Console.WriteLine("输入第二个整数");
                    _num2 = int.Parse(Console.ReadLine());
                    switch (_operator)
                    {
                        case '+':
                            _result = _num1 + _num2;
                            break;
                        case '-':
                            _result = _num1 - _num2;
                            break;
                        case '*':
                            _result = _num1 * _num2;
                            break;
                        case '/':
                            try
                            {
                                _result = _num1 / _num2;
                            }
                            catch (System.ArithmeticException)
                            {
                                isOK = false;
                                Console.WriteLine("除数不能为0");
                            }
                            break;
                        case '=':
                            isOK = false;
                            if (Equals(_num1, _num2))
                            {
                                Console.WriteLine("{0}与{1}相等", _num1, _num2);
                            }
                            else
                            {
                                Console.WriteLine("{0}与{1}不相等", _num1, _num2);
                            }
                            break;
                        default:
                            isOK = false;
                            Console.WriteLine("运算符错误");
                            break;
                    }
                    if (isOK)
                        Console.WriteLine("结果=" + _result);
                }
                catch (Exception)
                {
                    isOK = false;
                    Console.WriteLine("请按要求输入");
                }
            }

        }
        bool Equals(int x,int y)
        {
            if (x == y)
                return true;
            else
                return false;
        }

    }
}
