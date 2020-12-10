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
                   Name="A",
                   Discount=0.30f,
                   Id=1,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                new Product
               {
                   Name="B",
                   Discount=0.30f,
                   Id=2,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                 new Product
               {
                   Name="C",
                   Discount=0.30f,
                   Id=3,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                   new Product
               {
                   Name="D",
                   Discount=0.30f,
                   Id=4,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=1
               },
                       new Product
               {
                   Name="E",
                   Discount=0.30f,
                   Id=5,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                           new Product
               {
                   Name="F",
                   Discount=0.30f,
                   Id=6,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                               new Product
               {
                   Name="G",
                   Discount=0.30f,
                   Id=7,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                                                       new Product
               {
                   Name="H",
                   Discount=0.30f,
                   Id=8,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                                                                               new Product
               {
                   Name="L",
                   Discount=0.30f,
                   Id=9,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               },
                                                                                                       new Product
               {
                   Name="M",
                   Discount=0.30f,
                   Id=10,
                   PitcureUrl="https://cdn.dsmcdn.com//ty26/product/media/images/20201121/8/29616029/109201654/1/1_org.jpg",
                    Price=6999,
                    CategoryId=4
               }
           };
        }
    }
}
