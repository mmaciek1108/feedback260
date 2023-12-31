using static feedback360.TeacherBase;

namespace feedback360
{
    public interface ITeacher
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        event GradeAddedDeledate GradeAdded;

        Statistics GetStatistics();
    }
}