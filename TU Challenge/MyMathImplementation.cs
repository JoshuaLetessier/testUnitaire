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
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            
            throw new NotImplementedException();
        }

        public static int IsInOrder(int a, int b)
        {
            if (a == b)
                return 0;
            if (a > b)
                return -1;
            else
                return 1;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            if(arg1 == arg2)
                return 0;
            if(arg1 < arg2) 
                return -1;
            else
                return 1;
        }

        public static bool IsListInOrder(List<int> list)
        {
            int lastInt = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if(i == 0)
                {
                    lastInt = list[i];
                }
                else
                {
                    if(IsInOrder(lastInt, list[i]) == 1 || IsInOrder(lastInt, list[i]) == 0)
                    {
                        lastInt = list[i];
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            List<int> list = new List<int>();
            int lastInt = 0;
            int actualInt = 0;

            int sizeList = list.Count;
            int sizeToSort = toSort.Count;
            int indexList =0;

            for (int y = 0; y < toSort.Count; y++)
            {
                if(toSort.Count == 1)
                {
                    actualInt = toSort[y];
                }
                else
                {
                    for (int i = 0; i < toSort.Count; i++)
                    {
                        if (i == 0)
                        {
                            lastInt = toSort[i];
                            actualInt = lastInt;
                        }
                        else
                        {
                            if (IsInOrder(lastInt, toSort[i]) == -1)
                            {
                                actualInt = toSort[i];
                                indexList = i;
                                lastInt = toSort[i];
                            }
                        }
                    }
                }
                
                list.Add(actualInt);
                if (toSort.Remove(actualInt) == false)
                    new Exception("pas sup");
                actualInt = 0;
                indexList = 0;
            }
            return list;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i) == true)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0 && b > 0)
                return true;
            return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 18 && age > 0)
                return true;
            else if (age < 0)
                throw new ArgumentException("Valeur d'age négative");
            else if (age > 140)
                throw new ArgumentException("Valeur d'age trop grande vous êtes mort");
            else
                return false;
        }

        public static bool IsPrimary(int a)
        {
            for(int i = 2; i < a; i++)
            {
                if (IsDivisible(a, i) == true)
                    return false;
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public static int Power2(int a)
        {
            return (int)Math.Pow(a, 2);
        }


    }
}
