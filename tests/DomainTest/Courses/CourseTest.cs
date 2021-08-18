using Xunit;
using Xunit.Sdk;

namespace DomainTest.Courses
{
    //Eu enquanto admin quero poder criar e editar cursos para que sejam abertas matrículas para o mesmo.
    //Critérios de aceite
    //Criar um curso com nome, carga horária, público alvo e valor do curso; OK
    //As opções para público alvo são: estudante, universitário, empregado ou empreendedor; 
    //Todos os campos do curso são obrigatórios

    public class CourseTest
    {
        [Fact(DisplayName = "AdicionarCurso")]
        public void DeveCriarCurso()
        {
            var name = "TDD";
            var workLoad = 20;
            var targetAudience = "student";
            var price = 100.00;

            var course = new Course(name, workLoad, targetAudience, price);

            Assert.Equal(name, course.Name);
            Assert.Equal(workLoad, course.WorkLoad);
            Assert.Equal(targetAudience, course.TargetAudience);
            Assert.Equal(price, course.Price);
        }
    }
    
    public class Course
    {
        public string Name { get; private set; }
        public int WorkLoad { get; private set; }
        public string TargetAudience { get; private set; }
        public double Price { get; private set; }

        public Course(string name, int workLoad, string targetAudience, double price)
        {
            Name = name;
            WorkLoad = workLoad;
            TargetAudience = targetAudience;
            Price = price;
        }
    }
}