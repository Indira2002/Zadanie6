using System;
using System.Collections;
using System.Collections.Generic;
namespace zadanie6
{
    class Program
    {
        class Student
        {
            public int Id;
            public string Fio;
            public string Data_R;
            public string Group;

            public Student()
            {
            }
            public void AddId(int id)
            {
                Id = id;
            }
            public void AddName(string f)
            {
                Fio = f;
            }

            public void AddData(string d)
            {
                Data_R = d;
            }

            public void AddGroup(string g)
            {
                Group = g;
            }
            List<Student> list = new List<Student>();
            public void addStudent(Student st)
            {
                list.Add(st);
            }
            public void delStudent(Student st)
            {
                list.Remove(st);
            }
            public void Show()
            {
                foreach (var student in list)
                {
                    Console.WriteLine(student);
                }
            }
            public void Add()
            {
                int control;
                control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {

                    case 1:
                        Student st = new Student();
                        Console.WriteLine("Введите id:");
                        st.AddId(Console.Read());
                        Console.WriteLine("Введите фио:");
                        st.AddName(Console.ReadLine());
                        Console.WriteLine("Введите дату рождения:");
                        st.AddData(Console.ReadLine());
                        Console.WriteLine("Введите группу:");
                        st.AddGroup(Console.ReadLine());
                        addStudent(st);
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
            public void findid()
            {
                Console.WriteLine("id :");
                int i = Console.Read();
                bool ft = false;
                foreach (var student in list)
                {
                    Student st = (Student)student;
                    if (i == st.Id)
                    {
                        list.Add(st);
                        ft = true;
                    }
                }
                if (!ft)
                {
                    Console.WriteLine("Ошибка!");
                    return;
                
                }
                foreach (var student in list)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            public void find()
            {
                Console.WriteLine("Введите группу :");
                string i = Console.ReadLine();
                bool fg = false;
                foreach (var student in list)
                {
                    Student st = (Student)student;
                    if (i == st.Group)
                    {
                        list.Add(st);
                        fg = true;
                    }
                }
                if (!fg)
                {
                    Console.WriteLine("Студенты не найден");
                    return;

                }
                foreach (var student in list)
                {
                    Console.WriteLine(student.ToString());
                }
            }

        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { Id = 1, Fio = "  Айнулин Сергей Иванович  ",Data_R ="  12.09.2002  ", Group = "  ИСиП19-11-2"});
            list.Add(new Student { Id = 2, Fio = " Цветкова Людмила Ивановна  ", Data_R = "  02.01.2002  ", Group = "  ИСиП19-11-2" });
            foreach (Student s in list)
            {
                Console.Write(s.Id + "" + s.Fio + "" + s.Data_R + "" + s.Group + "; \n ");
            }
            Console.ReadLine();
        }

    }  
}

