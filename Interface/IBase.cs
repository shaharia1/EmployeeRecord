using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeRecord.Interface
{


  public interface IBase<T> where T : class   
  {
    IEnumerable<T> GetAll();
    T GetById(object id); 
    T Insert(T obj);
    void Update(T obj);
    void Delete(object id);
    void Save();

   

  }

}
