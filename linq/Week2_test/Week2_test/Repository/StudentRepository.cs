using Microsoft.AspNetCore.SignalR;
using Week2_test.Model;

namespace Week2_test.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> students = new List<Student>()
        {new Student(){StudId=1, StudName="deepa",Skill="CSE",Qualification="BSC"}
        };
        public void AddStudents(Student student)
        {
            try
            {
                students.Add(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.StudId == id)
                    {
                        students.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        public Student GetStudentById(int id)
        {
            try
            {
                foreach (var k in students)
                {
                    if (k.StudId == id)
                    {
                        return k;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentByQualification(string qual)
        {
            try
            {
                List<Student> studentsWithqual = new List<Student>();
                foreach (var item in students)
                {
                    if (item.Qualification == qual)
                        studentsWithqual.Add(item);
                }
                return studentsWithqual;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentBySkill(string sk)

        {
            try
            {
                List<Student> studentsWithSkill = new List<Student>();
                foreach (var item in students)
                {
                    if (item.Skill == sk)
                        studentsWithSkill.Add(item);
                }
                return studentsWithSkill;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Student student)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.StudId == student.StudId)
                    {
                        item.Skill = student.Skill;
                        item.Qualification = student.Qualification;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
