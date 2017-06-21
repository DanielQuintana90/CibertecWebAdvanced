using Cibertec.Models;
using Cibertec.UnitOfWork;
using Moq;
using System.Collections.Generic;

namespace Cibertec.Repositories.Tests
{
    public static class MockedUnitOfWork
    {
        public static IUnitOfWork GetUnitOfWork()
        {
            Mock<IUnitOfWork> unit = new Mock<IUnitOfWork>();
            unit.ConfigureCustomer();
            return unit.Object;
        }
    }

    public static class MockedUnitOfWorkExtensions
    {
        public static Mock<IUnitOfWork> ConfigureCustomer(this Mock<IUnitOfWork> mock)
        {
            mock.Setup(c => c.Customers.GetAll()).Returns(new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Daniel",
                    LastName = "Quintana",
                    Phone = "123456789",
                    Country = "Perú",
                    City = "Lima",
                    Orders = new List<Order>()
                },
                new Customer
                {
                    Id = 1,
                    FirstName = "André",
                    LastName = "Bedoya",
                    Phone = "987654321",
                    Country = "Brasil",
                    City = "Sao Paulo",
                    Orders = new List<Order>()
                }
            });

            mock.Setup(c => c.Customers.GetById(1)).Returns(new Customer
            {
                Id = 1,
                FirstName = "Daniel",
                LastName = "Quintana",
                Phone = "123456789",
                Country = "Perú",
                City = "Lima",
                Orders = new List<Order>()
            });

            mock.Setup(c => c.Customers.Insert(null)).Returns(1);

            mock.Setup(c => c.Customers.Update(null)).Returns(true);

            mock.Setup(c => c.Customers.Delete(null)).Returns(true);

            return mock;
        }
    }
}
