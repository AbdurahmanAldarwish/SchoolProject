using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrustructure.Abstracts;
using SchoolProject.Infrustructure.Data;
using SchoolProject.Infrustructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Repositories
{
    public class StudentRepository :GenericRepositoryAsync<Student>,IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _students;
        #endregion

        #region Constructors
        public StudentRepository(ApplicationDBContext dBContext):base(dBContext)
        {
            _students = dBContext.Set<Student>();
        }
        #endregion

        #region Handles Funtions
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _students.Include(x=>x.Department).ToListAsync();
        }
        #endregion

    }
}
