using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EmployeeRecord.Interface;
using EmployeeRecord.Models;

namespace EmployeeRecord.Repo
{
    public class Base<T> : IBase<T> where T : class
    {

        private ApplicationDbContext _context;
        private DbSet<T> table;

        public Base(ApplicationDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public T Insert(T obj)
        {
            table.Add(obj);
            Save();
            return obj;          
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            Save();
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }         

    }
}