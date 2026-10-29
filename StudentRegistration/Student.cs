using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Student
    {
        private int Id;
        private string name;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private char classLetter;
        private DateTime birthDate;

        public int id
        {
            get { return id; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Id", "Идентификаторът трябва да бъде положително цяло число.");
                }
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Името не може да бъде празно или само интервали.");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Age", "Възрастта трябва да бъде между 6 и 20 години.");
                }
                age = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Grade", "Класът трябва да бъде между 1 и 12.");
                }
                grade = value;
            }
        }

        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException("AverageScore", "Средният успех трябва да бъде между 2.00 и 6.00.");
                }
                averageScore = value;
            }
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Fee", "Таксата не може да бъде отрицателна.");
                }
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        // Свойство за Паралелка
        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Паралелката трябва да бъде буква.");
                }
                classLetter = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("BirthDate", "Датата на раждане не може да бъде бъдеща дата.");
                }
                birthDate = value;
            }
        }

        // Конструктор
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
