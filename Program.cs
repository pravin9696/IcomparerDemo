using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparerDemo
{
    class compareByTotalMarks : IComparer
    {
        public int Compare(object x, object y)
        {
            student temp1 = x as student;
            student temp2 = (student)y;
            if (temp1.total_marks > temp2.total_marks)
            {
                return 1;
            }
            else if (temp1.total_marks < temp2.total_marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class compareByName : IComparer
    {
        public int Compare(object x, object y)
        {
            student temp1 = x as student;
            student temp2 = (student)y;
            if (string.Compare(temp1.name,temp2.name)>0)
            {
                return 1;
            }
            else if (string.Compare(temp1.name, temp2.name) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class compareByRoll : IComparer
    {
        public int Compare(object x, object y)
        {
            student temp1= x as student;
            student temp2 = (student)y;
            //logic to sort Arraylist by Roll number
            if (temp1.roll > temp2.roll)
            {
                return 1;
            }
            else if (temp1.roll < temp2.roll)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
    //use Icomparable
    class student:IComparable
    {
        public int roll { get; set; }
        public string name { get; set; }
        public int total_marks { get; set; }

        public int CompareTo(object obj)
        {
            student temp = (student)obj;
            //logic to sort Arraylist by Roll number
            //if (this.roll<temp.roll)
            //{
            //    return 1;
            //}
            //else if (this.roll > temp.roll)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
            //logic to sort ArrayList by Total Marks
            //if (this.total_marks < temp.total_marks)
            //{
            //    return 1;
            //}
            //else if (this.total_marks > temp.total_marks)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            //logic to sort ArrayList by Name
            //return string.Compare(this.name, ((student)obj).name)*(-1);
              if(string.Compare(this.name, ((student)obj).name)>0)
            {
                //return -1;//for desc order
                return 1; //for asc order
            }
            else if (string.Compare(this.name, ((student)obj).name)<0)
            {
                //return 1;//for desc order
                return -1;//for asc order
            }
            else
            {
                return 0;
            }
        }

        public void show()
        {
            Console.WriteLine($"Roll = {roll} Name= {name} Total Marks= {total_marks}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList ar1=new ArrayList();
            //ar1.Add("pune");
            //ar1.Add("Nashik");
            //ar1.Add("Delhi");

            //foreach (var item in ar1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------");
            //ar1.Sort();
            //foreach (var item in ar1)
            //{
            //    Console.WriteLine(item);
            //}

            ArrayList stArrayList = new ArrayList();
            student s1 = new student() { roll = 1, name = "Rajesh", total_marks = 345 };
            student s2 = new student() { roll = 3, name = "Anil", total_marks = 543 };
            student s3 = new student() { roll = 2, name = "Pankaj", total_marks = 123 };
            student s4 = new student() { roll = 4, name = "Dinesh", total_marks = 878 };

            stArrayList.Add(s1);
            stArrayList.Add(s2);
            stArrayList.Add(s3);
            stArrayList.Add(s4);


            foreach (var item in stArrayList)
            {
                student temp = (student)item;
                temp.show();
            }
            //stArrayList.Sort();
            compareByRoll cbr = new compareByRoll();
            stArrayList.Sort(cbr);
            Console.WriteLine("-------------------");
            foreach (var item in stArrayList)
            {
                student temp = (student)item;
                temp.show();
            }
            compareByName cbn = new compareByName();
            //stArrayList.Sort(cbn);
            stArrayList.Sort(new compareByName());
            Console.WriteLine("-------------------");
            foreach (var item in stArrayList)
            {
                student temp = (student)item;
                temp.show();
            }
            compareByTotalMarks cbtm = new compareByTotalMarks();
            stArrayList.Sort(cbtm);
            Console.WriteLine("-------------------");
            foreach (var item in stArrayList)
            {
                student temp = (student)item;
                temp.show();
            }
            Console.ReadKey();
        }
    }
}
