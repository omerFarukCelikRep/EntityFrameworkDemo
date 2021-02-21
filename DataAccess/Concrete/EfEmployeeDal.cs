using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(Expression<Func<Employee, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Employee>().ToList() : context.Set<Employee>().Where(filter).ToList();
            }
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
