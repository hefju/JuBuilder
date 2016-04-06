using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder2.DAL
{
    class IRepository
    {// shared between repositories
        public interface IGenericRepository<T>
        {
            T CreateNew();

            void Delete(T item);
            void Update(T item);
            void Insert(T item);

            IEnumerable<T> FindAll();
            T FindOne(int id);

            //   IQueryable<T> Query { get; } //linq
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
    }

    class YourImplementationOfUnitOfWork:JuBuilder2.DAL.IRepository.IUnitOfWork
    {

        public IRepository.IAnimalRepository AnimalRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository.IHumanRepository HumanRepository
        {
            get { throw new NotImplementedException(); }
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    class Animal
    {
        public int ID{get;set;}
        public string Name { get; set; }
    }

    class Human
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class TestCode
    {
       public void mytest()
        {
            // example code
            using (JuBuilder2.DAL.IRepository.IUnitOfWork uow = new YourImplementationOfUnitOfWork())
            {
               // var animals = uow.AnimalRepository.Query.Where(a => a.NumberOfLegs == 3);
                var animals = uow.AnimalRepository.FindByNumberOfLegs(3);

                var person = uow.HumanRepository.CreateNew();
                person.Name = "John";
                uow.HumanRepository.Insert(person);

                uow.SaveChanges();
            }
        }
    }
}
