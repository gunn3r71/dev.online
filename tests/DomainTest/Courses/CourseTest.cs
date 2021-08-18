using ExpectedObjects;
using Xunit;

namespace DomainTest.Courses
{
    //Eu enquanto admin quero poder criar e editar cursos para que sejam abertas matrículas para o mesmo.
    //Critérios de aceite
    //Criar um curso com nome, carga horária, público alvo e valor do curso; OK
    //As opções para público alvo são: estudante, universitário, empregado ou empreendedor;  OK
    //Todos os campos do curso são obrigatórios;

    public class CourseTest
    {
        [Fact(DisplayName = "AdicionarCurso")]
        public void DeveCriarCurso()
        {
            var expectedCourse = new
            {
                Name = "TDD",
                WorkLoad = 20,
                TargetAudience = TargetAudience.CollegeStudents,
                Price = 100.00
            };

            var course = new Course(expectedCourse.Name, expectedCourse.WorkLoad, expectedCourse.TargetAudience, expectedCourse.Price);

            expectedCourse.ToExpectedObject().ShouldMatch(course);
        }
    }

    public enum TargetAudience
    {
        Students,
        CollegeStudents,
        Employees,
        Entrepreneur
    }

    public class Course
    {
        public string Name { get; private set; }
        public int WorkLoad { get; private set; }
        public TargetAudience TargetAudience { get; private set; }
        public double Price { get; private set; }

        public Course(string name, int workLoad, TargetAudience targetAudience, double price)
        {
            Name = name;
            WorkLoad = workLoad;
            TargetAudience = targetAudience;
            Price = price;
        }
    }
}