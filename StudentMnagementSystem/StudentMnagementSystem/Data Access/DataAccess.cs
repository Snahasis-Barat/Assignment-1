using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StudentMnagementSystem.Models;
namespace StudentMnagementSystem.Data_Access
{
    public class DataAccess
    {
        List<Student> s = new List<Student>();
        public void AddData()
        {
            //students = new Student();
            Student ob = new Student();
            Console.WriteLine("Enter student id,name,standard,address");

            ob.id = int.Parse(Console.ReadLine());
            ob.name = Console.ReadLine();
            ob.standard = Console.ReadLine();
            ob.address = Console.ReadLine();
            Console.WriteLine("Enter no of subject");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("subject details");
            ob.subjects = new List<Subject>();
            for (int i = 0; i < n; i++)
            {
                Subject o = new Subject();
                o.sId = int.Parse(Console.ReadLine());
                o.name = Console.ReadLine();
                o.max = int.Parse(Console.ReadLine());
                o.marksObtained = int.Parse(Console.ReadLine());
                ob.subjects.Add(o);

            }
            Console.WriteLine("Data inserted");
            s.Add(ob);



        }

        public void getData()
        {
            for (int i = 0; i < s.Count; i++)
            {
                var j = s[i];
                Console.WriteLine(j.id + " " + j.name + " " + j.address + " " + j.standard);
                foreach (var sub in j.subjects)
                {
                    Console.WriteLine(sub.sId + " " + sub.name + " " + sub.max + " " + sub.marksObtained);
                }
            }
        }
        public void getDataId(int Id)
        {
            int flag = 0;
            for (int i = 0; i < s.Count; i++)
            {
                var j = s[i];
                if (j.id == Id)
                {
                    flag = 1;
                    Console.WriteLine(j.id + " " + j.name + " " + j.address + " " + j.standard);
                    foreach (var sub in j.subjects)
                    {
                        Console.WriteLine(sub.sId + " " + sub.name + " " + sub.max + " " + sub.marksObtained);
                    }
                }

            }
            if(flag==0)
            {
                Console.WriteLine("Wrong id");
            }
        }

        public void updateId(int Id)
        {
            int flag = 0;
            for (int i = 0; i < s.Count; i++)
            {
                var j = s[i];
                if (j.id == Id)
                {
                    flag = 1;
                    Console.WriteLine("Enter new details");
                    j.name = Console.ReadLine();
                    j.standard = Console.ReadLine();
                    j.address = Console.ReadLine();
                    Console.WriteLine("Enter no of subject");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter subject id name,max marks,marks obtained");
                    j.subjects = new List<Subject>();
                    for (int k = 0; k < n; k++)
                    {
                        Subject o = new Subject();
                        o.sId = int.Parse(Console.ReadLine());
                        o.name = Console.ReadLine();
                        o.max = int.Parse(Console.ReadLine());
                        o.marksObtained = int.Parse(Console.ReadLine());
                        j.subjects.Add(o);
                        Console.WriteLine("Data updated");

                    }

                }
                
            }
            if(flag==0)
            {
                Console.WriteLine("Wrong id");
            }
        }
        public void deleteId(int Id)
        {
            int flag = 0;
            for (int i = 0; i < s.Count; i++)
            {
                var j = s[i];
                if (j.id == Id)
                {
                    flag = 1;
                    s.RemoveAt(i);
                }
            }
            if(flag==0)
            {
                Console.WriteLine("Wrong id");
            }
        }
    }
}
