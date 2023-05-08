using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE12_4
{
    public class Schedule
    {
        public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
        public DateTime startTime;
        public DateTime endTime;
    }
    public class Course
    {
        public string courseCode;
        public string description;
        public string teacherEmail;
        public Schedule schedule;

        public Course(String courseCode, string description)
        {
            this.courseCode = courseCode;
            this.description = description;
        }
    }
    public class Courses
    {
        public SortedList<string, Course> sortedList = new SortedList<string, Course>();
        public void Remove(string courseCode)
        {
            sortedList.Remove(courseCode);
        }

        public Courses()
        {
            Course thisCourse;
            Schedule thisSchedule;

            Random rand = new Random();

            // generate courses IGME-200 through IGME-299
            for (int i = 200; i < 300; ++i)
            {
                // use constructor to create new course object with code and description
                thisCourse = new Course(($"IGME-{i}"), ($"Description for IGME-{i}"));

                // create a new Schedule object
                thisSchedule = new Schedule();
                for (int dow = 0; dow < 7; ++dow)
                {
                    // 50% chance of the class being on this day of week
                    if (rand.Next(0, 2) == 1)
                    {
                        // add to the daysOfWeek list
                        thisSchedule.daysOfWeek.Add((DayOfWeek)dow);

                        // select random hour of day
                        int nHour = rand.Next(0, 24);

                        // set start and end times of minute duration
                        // select fixed date to allow time calculations
                        thisSchedule.startTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.endTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                // set the schedule for this course
                thisCourse.schedule = thisSchedule;

                // add this course to the SortedList
                sortedList[thisCourse.courseCode] = thisCourse;
            }
        }

    }
    public abstract class Person : IComparable<Person>
    {
        public string name;
        public int age;
        public string email;
        private int licenseId;

        public int LicenseId
        {
            get
            {
                // get will simply return licenseId but it can do any logic
                return licenseId;
            }

            set
            {
                // we will only set the licenseId if the person is older than 16
                if (age > 16)
                {
                    licenseId = value;
                }
            }
        }

        // if person1 < person2
        // if (Person)student1 < (Person)student2
        public static bool operator <(Person p1, Person p2)
        {
            return (p1.age < p2.age);
        }

        public static bool operator >(Person p1, Person p2)
        {
            return (p1.age > p2.age);
        }

        public static bool operator <=(Person p1, Person p2)
        {
            return (p1.age <= p2.age);
        }

        public static bool operator >=(Person p1, Person p2)
        {
            return (p1.age >= p2.age);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.age == p2.age);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return (p1.age != p2.age);
        }

        public virtual void Work()
        {
            Console.WriteLine("work work work");
        }

        public int CompareTo(Person p)
        {
            return this.name.CompareTo(p.name);
        }
    }

    public interface IStudent
    {
        void Party();
    }

    public interface IPerson
    {
        void Eat();
    }

    public class Student : Person, IPerson, IStudent
    {
        public double gpa;

        // if student1 < student2
        public static bool operator <(Student s1, Student s2)
        {
            return (s1.gpa < s2.gpa);
        }

        public static bool operator <=(Student s1, Student s2)
        {
            return (s1.gpa <= s2.gpa);
        }

        public static bool operator >(Student s1, Student s2)
        {
            return (s1.gpa > s2.gpa);
        }

        public static bool operator >=(Student s1, Student s2)
        {
            return (s1.gpa >= s2.gpa);
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return (s1.gpa == s2.gpa);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return (s1.gpa != s2.gpa);
        }

        public void Eat()
        {
            Console.WriteLine("Order a pizza!");
        }

        public void Party()
        {
            Console.WriteLine("Party on dude");
        }

    }

    public class Teacher : Person, IPerson
    {
        public string specialty;

        public override void Work()
        {
            // we can optionally call the parent's default method as well
            base.Work();
            Console.WriteLine($"I'll tell you all about {specialty}.");
        }

        public void Eat()
        {
            Console.WriteLine("I eat lots of apples.");
        }
    }

    // [+People|sortedList:SortedList<string, Person>|this:email;+Remove(email: string)]
    public class People
    {
        // the generic SortedList class uses a template <> to store indexed data
        // the first type is the data type to index on
        // the second type is the data type to store in the list
        // create a Sorted List indexed on email (string) and storing Person objects
        public SortedList<string, Person> sortedList = new SortedList<string, Person>();

        public void Remove(string email)
        {
            if (email != null)
            {
                sortedList.Remove(email);
            }
        }

        // indexer property allows array access to sortedList via the class object
        // and catching missing keys and duplicate key exceptions 
        // notice the indexer property definition shows how it will be used in the calling code:
        // if we have:
        //     People peopleList;
        // then we can call:
        //     peopleList[email] to access the Person object with that email address
        // and value will be the Person object (person) being added to the list in the case of:
        //     get example: profSchuh = peopleList['dxsigm@rit.edu']
        //     set example: peopleList[profSchuh.email] = profSchuh;
        public Person this[string email]
        {
            get
            {
                Person returnVal;
                try
                {
                    returnVal = (Person)sortedList[email];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                try
                {
                    // we can add to the list using these 2 methods
                    //      sortedList.Add(email, value);
                    sortedList[email] = value;
                }
                catch
                {
                    // an exception will be raised if an entry with a duplicate key is added
                    // duplicate key handling
                }
            }
        }
    }
}
