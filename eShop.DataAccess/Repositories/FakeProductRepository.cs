using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.DataAccess.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return new List<Product>
           {
               new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=1,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=2,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                 new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=3,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                   new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=4,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                       new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=5,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                           new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=6,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                               new Product
               {
                   Name="Acer",
                   Discount=0.30f,
                   Id=7,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               }
           };
        }
    }
}
