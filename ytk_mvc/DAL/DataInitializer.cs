using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ytk_mvc.Entity;

namespace ytk_mvc.DAL
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //
            var Users = new List<User>()
            {
                new User(){ Name = "Admin", Password="123", Role="admin"}
            };

            foreach (var user in Users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
            //
            var Categories = new List<Category>()
            {
                new Category(){ Name="Pencere", Description="açıklama", IsVisible=true},
                new Category(){ Name="Kapı", Description="açıklama", IsVisible=true},
                new Category(){ Name="Balkon", Description="açıklama", IsVisible=true}
            };

            foreach (var category in Categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();
            //
            var ImageFolders = new List<ImageFolder>()
            {
                new ImageFolder(){ Name = "sliders"},
                new ImageFolder(){ Name = "Project-1"},
                new ImageFolder(){ Name = "Product-1"},
                new ImageFolder(){ Name = "Partner-1"},
                new ImageFolder(){ Name = "Project-2"},
                new ImageFolder(){ Name = "Project-3"},
                new ImageFolder(){ Name = "Product-2"}

            };

            foreach (var imagefolder in ImageFolders)
            {
                context.ImageFolders.Add(imagefolder);
            }
            context.SaveChanges();
            //
            var Images = new List<Image>()
            {
                new Image(){ ImageName = "slide-1.jpg", Description="pikapen", ImageFolderId=1},
                new Image(){ ImageName = "slide-2.jpg", Description="pikapen", ImageFolderId=1},
                new Image(){ ImageName = "slide-3.jpg", Description="pikapen", ImageFolderId=1},
                new Image(){ ImageName = "0.jpg", Description="pikapen", ImageFolderId=2},
                new Image(){ ImageName = "Product-1-1.jpg", Description="pikapen", ImageFolderId=3},
                new Image(){ ImageName = "Partner-1-1.jpg", Description="pikapen", ImageFolderId=4},
                new Image(){ ImageName = "0.jpg", Description="pikapen", ImageFolderId=5},
                new Image(){ ImageName = "1.jpg", Description="pikapen", ImageFolderId=5},
                new Image(){ ImageName = "2.jpg", Description="pikapen", ImageFolderId=5},
                new Image(){ ImageName = "1.jpg", Description="pikapen", ImageFolderId=2},
                new Image(){ ImageName = "2.jpg", Description="pikapen", ImageFolderId=2},
                new Image(){ ImageName = "0.jpg", Description="pikapen", ImageFolderId=6},
                new Image(){ ImageName = "0.jpg", Description="pikapen", ImageFolderId=7},
                new Image(){ ImageName = "1.jpg", Description="pikapen", ImageFolderId=6},
                new Image(){ ImageName = "2.jpg", Description="pikapen", ImageFolderId=6}


            };

            foreach (var image in Images)
            {
                context.Images.Add(image);
            }
            context.SaveChanges();
            //
            var Clients = new List<Client>()
            {
                new Client(){ ClientName="İbrahim GEZER", CompanyName="Derya Sitesi", Adress="A108 Adam Street, New York, NY 535022", Phone="+1 5589 55488 55", Email="contact@example.com"},
                new Client(){ ClientName="İsmail GEZER", CompanyName="Ola Sitesi", Adress="A7077 Adam Street, New York, NY 535022", Phone="+1 5589 55488 55", Email="contact1@example.com"},
                new Client(){ ClientName="Zafer GEZER", CompanyName="Dostlar Apartmanı", Adress="A677 Adam Street, New York, NY 535022", Phone="+1 5589 55488 55", Email="dostlar@example.com"}
            };

            foreach (var client in Clients)
            {
                context.Clients.Add(client);
            }
            context.SaveChanges();

            //
            var Projects = new List<Project>()
            {
                new Project(){ Name = "Derya sitesi", Description="sitenin pencereleri takıldı", Price=10000,Date=DateTime.Now, IsVisible=true, ClientId=1, CategoryId=1, ImageFolderId=2 },
                new Project(){ Name = "Ola sitesi", Description="sitenin kapıları takıldı", Price=10000,Date=DateTime.Now, IsVisible=true, ClientId=2, CategoryId=2, ImageFolderId=5 },
                new Project(){ Name = "Dostlar Apartmanı", Description="apartmanın bolkonları yapıldı", Price=25000,Date=DateTime.Now, IsVisible=true, ClientId=3, CategoryId=3, ImageFolderId=6 }

            };

            foreach (var project in Projects)
            {
                context.Projects.Add(project);
            }
            context.SaveChanges();
            //
            var Products = new List<Product>()
            {
                new Product(){ Name = "Pikapen pencere", Description="ayazpen pencere", Price=200, Stock=50, CategoryId=1, ImageFolderId=3 },
                new Product(){ Name = "Pikapen kapı", Description="ayazpen kapı", Price=400, Stock=50, CategoryId=2, ImageFolderId=7 }

            };

            foreach (var product in Products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
            //
            var Partners = new List<Partner>()
            {
                new Partner(){ Name = "PikaPen", Description="pikapen", WebSite="www.pikapen.com", ImageFolderId=4}

            };

            foreach (var partner in Partners)
            {
                context.Partners.Add(partner);
            }
            context.SaveChanges();

            //
            var ContactInfos = new List<ContactInfo>()
            {
                new ContactInfo(){ Adress="A108 Adam Street, New York, NY 535022", Phone="+1 5589 55488 55", Email="contact@example.com" }
            };

            foreach (var contactinfo in ContactInfos)
            {
                context.ContactInfos.Add(contactinfo);
            }
            context.SaveChanges();



            base.Seed(context);
        }
    }
}