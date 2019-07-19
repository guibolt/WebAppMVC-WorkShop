using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext Context;

        public DepartmentService(SalesWebMvcContext context)
        {
            Context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await Context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
 