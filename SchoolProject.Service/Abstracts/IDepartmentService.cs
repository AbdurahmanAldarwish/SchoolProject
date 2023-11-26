using SchoolProject.Data.Entities;

namespace SchoolProject.Service.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int Id);
        public Task<bool> IsDepartmentIdExist(int departmentId);
    }
}
