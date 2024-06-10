using CourseERP.Business.Implementations;
using CourseERP.Business.Interfaces;
using CourseERP.Core.Models;

namespace CourseERP.CA
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            GroupService groupService = new GroupService();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Group Operations:");
                Console.WriteLine("   1. Create() Group");
                Console.WriteLine("   2. Get() Group");
                Console.WriteLine("   3. GetAll() Groups");
                Console.WriteLine("   4. Remove() Group");
                Console.WriteLine("   5. Exit");
                Console.WriteLine("2. Student Operations:");
                Console.WriteLine("   1. Create() Student");
                Console.WriteLine("   2. Get() Student");
                Console.WriteLine("   3. GetAll() Student");
                Console.WriteLine("   4. Remove() Student");
                Console.WriteLine("   5. Exit");
                Console.WriteLine("3. Add student to group");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GroupOperations(groupService);
                        break;
                    case 2:
                        StudentOperations(studentService);
                        break;
                    case 3:
                        AddStudentToGroup(studentService, groupService);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void GroupOperations(GroupService groupService)
        {
            while (true)
            {
                Console.WriteLine("Group Operations:");
                Console.WriteLine("1. Create() Group");
                Console.WriteLine("2. Get() Group");
                Console.WriteLine("3. GetAll() Groups");
                Console.WriteLine("4. Remove() Group");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter group ID: ");
                        int groupId = int.Parse(Console.ReadLine());
                        Console.Write("Enter group name: ");
                        string groupName = Console.ReadLine();
                        Group newGroup = new Group { Id = groupId, Name = groupName };
                        groupService.Create(newGroup);
                        Console.WriteLine("Group created.");
                        break;
                    case 2:
                        Console.Write("Enter group ID: ");
                        int getGroupId = int.Parse(Console.ReadLine());
                        try
                        {
                            Group group = groupService.Get(getGroupId);
                            Console.WriteLine("Group: " + group.Name);
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        List<Group> groups = groupService.GetAll();
                        Console.WriteLine("Groups count: " + groups.Count);
                        foreach (var group in groups)
                        {
                            Console.WriteLine(group.Name);
                        }
                        break;
                    case 4:
                        Console.Write("Enter group ID: ");
                        int removeGroupId = int.Parse(Console.ReadLine());
                        try
                        {
                            groupService.Remove(removeGroupId);
                            Console.WriteLine("Group removed.");
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void StudentOperations(StudentService studentService)
        {
            while (true)
            {
                Console.WriteLine("Student Operations:");
                Console.WriteLine("1. Create() Student");
                Console.WriteLine("2. Get() Student");
                Console.WriteLine("3. GetAll() Student");
                Console.WriteLine("4. Remove() Student");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student ID: ");
                        int studentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter student name: ");
                        string studentName = Console.ReadLine();
                        Student newStudent = new Student { Id = studentId, Fullname = studentName };
                        studentService.Create(newStudent);
                        Console.WriteLine("Student created.");
                        break;
                    case 2:
                        Console.Write("Enter student ID: ");
                        int getStudentId = int.Parse(Console.ReadLine());
                        try
                        {
                            Student student = studentService.Get(getStudentId);
                            Console.WriteLine("Student: " + student.Fullname);
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        List<Student> students = studentService.GetAll();
                        Console.WriteLine("Students count: " + students.Count);
                        foreach (var student in students)
                        {
                            Console.WriteLine(student.Fullname);
                        }
                        break;
                    case 4:
                        Console.Write("Enter student ID: ");
                        int removeStudentId = int.Parse(Console.ReadLine());
                        try
                        {
                            studentService.Remove(removeStudentId);
                            Console.WriteLine("Student removed.");
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudentToGroup(StudentService studentService, GroupService groupService)
        {
            Console.Write("Enter student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter group ID: ");
            int groupId = int.Parse(Console.ReadLine());

            try
            {
                Student student = studentService.Get(studentId);
                Group group = groupService.Get(groupId);

                Console.WriteLine("Student " + student.Fullname + " added to group " + group.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
