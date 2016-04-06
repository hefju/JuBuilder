using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder2
{
    //这种模式跟ef差不多, 但不是我想要的

    // shared between repositories
    public interface IGenericRepository<T>
    {
        T CreateNew();

        void Delete(T item);
        void Update(T item);
        void Insert(T item);

        IEnumerable<T> FindAll();
        T FindOne(int id);

        IQueryable<T> Query { get; }
    }


    // specific repositories
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        IEnumerable<Animal> FindByNumberOfLegs(int NumberOfLegs);
        // ... anything specific follows
    }

    public interface IHumanRepository : IGenericRepository<Human>
    {
        IEnumerable<Human> FindByGender(string gender);
        //  ... specific repository logic follows
    }

    // unit of work - a service for clients
    public interface IUnitOfWork : IDisposable
    {
        IAnimalRepository AnimalRepository { get; }
        IHumanRepository HumanRepository { get; }
        // .. other repositories follow

        void SaveChanges();
    }


    public class testcode
    {
        public void mytest()
        {
            // example code
            using (IUnitOfWork uow = new YourImplementationOfUnitOfWork())
            {
                var animals = uow.AnimalRepository.FindByNumberOfLegs(3);

                var person = uow.HumanRepository.CreateNew();
                person.Name = "John";
                uow.HumanRepository.Insert(person);

                uow.SaveChanges();
            }
        }

        public void mytest_linq()
        {
            // example code
            using (IUnitOfWork uow = new YourImplementationOfUnitOfWork())
            {
                var animals = uow.AnimalRepository.Query.Where(a => a.NumberOfLegs == 3);

                var person = uow.HumanRepository.CreateNew();
                person.Name = "John";
                uow.HumanRepository.Insert(person);

                uow.SaveChanges();
            }
        }
    }


    //interface IRepository
    //{

    //}
}
