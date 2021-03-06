﻿using Learning.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Web.Data
{
    public class SeedDB
    {
        private readonly DataContext context;
        private Random random;

        public SeedDB(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Products.Any())
            {
                this.AddProduct("Asus RTX2070 Strix");
                this.AddProduct("Intel Core i7 9900K");
                this.AddProduct("WD Green 480GB");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(1000),
                IsAvailable = true,
                Stock = this.random.Next(100)
            });

        }
    }
}
