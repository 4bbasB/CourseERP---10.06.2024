using CourseERP.Business.Interfaces;
using CourseERP.Core.Models;
using GroupERPDATABASE.DAL;

namespace CourseERP.Business.Implementations;

public class StudentService : IStudentService
{
    public void Create(Student student)
    {
        CourseERPDATABASE.Students.Add(student);    
    }

    public Student Get(int id)
    {
        Student? wantedStudent = CourseERPDATABASE.Students.Find(x=> x.Id == id);

        if (wantedStudent is null)
            throw new NullReferenceException("Student not found!");

        return wantedStudent;
    }

    public List<Student> GetAll()
    {
        return CourseERPDATABASE.Students;
    }

    public void Remove(int id)
    {
        Student? wantedStudent = CourseERPDATABASE.Students.Find(x => x.Id == id);

        if (wantedStudent is null)
            throw new NullReferenceException("Student not found!");

        CourseERPDATABASE.Students.Remove(wantedStudent);
    }
}
