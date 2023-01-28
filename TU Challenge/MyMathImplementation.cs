using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
            throw new NotImplementedException();
        }

        public static object GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            var result = new List<int>();
            int i = 2;
            while (i<=a)
            {
                if(IsPrimary(i))
                {
                    result.Add(i);
                }
                i++;
            }
            return result;
            throw new NotImplementedException();
        }

        public static bool IsDivisible(int a, int b)
        {
            return a % b == 0;
            throw new NotImplementedException();
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
            throw new NotImplementedException();
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b) return 1;
            else if (a > b) return -1;
            else return 0;
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {

            for (int i = 0; i < list.Count()-1; i++)
            {
                if (!(list[i] <= list[i + 1]))
                {
                    return false;
                }
            }
            return true;
            throw new NotImplementedException();
        }

        public static bool IsMajeur(int age)
        {
            if (age<150 && age >= 0)
            {
                return age > 17;
            }
            throw new ArgumentException();
        }

        public static bool IsPrimary(int a)
        {
            if (a == 2 || a == 3 || a == 5 || a == 7) return true;
            else if (!(a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0)) return true;
            else return false;
            throw new NotImplementedException();
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
            throw new NotImplementedException();
        }

        public static int Power2(int a)
        {
            return a * a;
            throw new NotImplementedException();
        }

        public static List<int> Sort(List<int> toSort)
        {
            var sorted = new List<int>();
            for (int i = 0;i < toSort.Count; i++)
            {
                int min = toSort.Min();
                toSort.Remove(min);
                sorted.Add(min);
            }
            return sorted;
            
            throw new NotImplementedException();
        }
    }
}
