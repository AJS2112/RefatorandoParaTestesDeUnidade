using System;
using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeDiscountRepository : IDiscountRepository
    {
        public Discount Get(string code)
        {
            if (code == "1111")
                return new Discount(10, DateTime.Now.AddDays(5));

            if (code == "0000")
                return new Discount(10, DateTime.Now.AddDays(-1));

            return null;
        }
    }
}