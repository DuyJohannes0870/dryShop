using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of DryShop" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of DryShop" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of DryShop" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Đậu Hạt", LanguageId = "vi", SeoAlias = "hat-dau", SeoDescription = "Hạt đậu khô", SeoTitle = "Hạt đậu khô" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Pea", LanguageId = "en", SeoAlias = "pea", SeoDescription = "Dried peas", SeoTitle = "Dried peas" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Hải Sản", LanguageId = "vi", SeoAlias = "hai-san", SeoDescription = "Hải sản khô", SeoTitle = "Hải sản khô" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Seafood", LanguageId = "en", SeoAlias = "seafood", SeoDescription = "Dried seafood", SeoTitle = "Dried seafood" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           },
           new Product()
           {
               Id = 2,
               DateCreated = DateTime.Now,
               OriginalPrice = 200000,
               Price = 300000,
               Stock = 0,
               ViewCount = 0,
           }
           );
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Hạt hướng dương",
                     LanguageId = "vi",
                     SeoAlias = "hat-huong-duong",
                     SeoDescription = "Hạt hướng dương",
                     SeoTitle = "Hạt hướng dương",
                     Details = "Hạt hướng dương",
                     Description = "Hạt hướng dương"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Sunflower seed",
                        LanguageId = "en",
                        SeoAlias = "sunflower-seed",
                        SeoDescription = "Sunflower seed",
                        SeoTitle = "Sunflower seed",
                        Details = "Sunflower seed",
                        Description = "Sunflower seed"
                    },


                    new ProductTranslation()
                    {
                        Id = 3,
                        ProductId = 2,
                        Name = "Hạt macca cao cấp",
                        LanguageId = "vi",
                        SeoAlias = "hat-macca-cao-cap",
                        SeoDescription = "Hạt macca cao cấp",
                        SeoTitle = "Hạt macca cao cấp",
                        Details = "Hạt macca cao cấp",
                        Description = "Hạt macca cao cấp"
                    },
                    new ProductTranslation()
                    {
                        Id = 4,
                        ProductId = 2,
                        Name = "Premium macadamia nuts",
                        LanguageId = "en",
                        SeoAlias = "Premium-macadamia-nuts",
                        SeoDescription = "Premium macadamia nuts",
                        SeoTitle = "Premium macadamia nuts",
                        Details = "Premium macadamia nuts",
                        Description = "Premium macadamia nuts"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "bizz432000@gmail.com",
                NormalizedEmail = "bizz432000@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FirstName = "Duy",
                LastName = "Khuong",
                Dob = new DateTime(2000, 03, 04)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );
        }
    }
}