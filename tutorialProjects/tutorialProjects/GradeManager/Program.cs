using System.Diagnostics;

namespace GradeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, List<int>> StudentDictionary = new Dictionary<string, List<int>>();


            void AddGrade(string studentName, int grade)
            {
                // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
                if (StudentDictionary.TryGetValue(studentName, out var student))
                {
                    StudentDictionary[studentName].Add(grade);
                }
            }

            void RemoveGrade(string studentName, int grade)
            {
                // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
                if (StudentDictionary.TryGetValue(studentName, out var student))
                {
                    StudentDictionary[studentName].RemoveAll(s => s == grade);
                }
            }

            double CalculateAverageGrade(string studentName)
            {
                // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
                if (StudentDictionary.TryGetValue(studentName, out var student))
                {
                    return StudentDictionary[studentName].Average();
                }
                return 0;
            }
        }
    }
}
