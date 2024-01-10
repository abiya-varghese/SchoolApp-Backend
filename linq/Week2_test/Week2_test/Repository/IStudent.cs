using Week2_test.Model;

namespace Week2_test.Repository
{
    public interface IStudent
    {
        public void AddStudents(Student student);
        List<Student> GetStudentByQualification(string qual);
        List<Student> GetStudentBySkill(string sk);
        void Update(Student student);
        void Delete(int id);
        Student GetStudentById(int id);

    }
}
