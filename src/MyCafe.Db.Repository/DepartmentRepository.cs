using Microsoft.EntityFrameworkCore;

using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MyCafeContext _context;

        public DepartmentRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Department department)
        {
            _context.Add(department);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Department department)
        {
            _context.Remove(department);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<IEnumerable<Department>> GetByFirmId(int firmId)
        {
            return await _context.Departments.Where(p => p.FirmId == firmId).ToListAsync();
        }

        public async Task<Department> GetById(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        public async Task<int> Update(Department department)
        {
            _context.Departments.Update(department);
            return await _context.SaveChangesAsync();
        }
    }
}
