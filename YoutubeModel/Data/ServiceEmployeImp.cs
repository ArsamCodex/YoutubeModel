using YoutubeModel.Model;

namespace YoutubeModel.Data
{
    public class ServiceEmployeImp : IServiceEmployee
    {

        private readonly AplcationDbContext _context;

        public ServiceEmployeImp(AplcationDbContext context)
        {
            _context = context;
        }
        public List<Employee> Getemployees()
        {
            return _context.Employee.ToList();
        }
        //Here there was aan error here just remove whit spaces at this line its ok
        public void SaveEmployee(Employee employee)
        {
            if (employee.Id == 0) _context.Employee.Add(employee);
            else _context.Employee.Update(employee);
            _context.SaveChanges();
        }

       
    }
}
