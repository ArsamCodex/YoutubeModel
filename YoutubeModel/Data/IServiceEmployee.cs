using YoutubeModel.Model;

namespace YoutubeModel.Data
{
    public interface IServiceEmployee
    {
        List<Employee> Getemployees();

        void SaveEmployee(Employee employee);


    }
}
