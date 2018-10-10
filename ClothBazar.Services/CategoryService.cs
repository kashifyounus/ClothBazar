using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
    public class CategoryService
    {
        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Category.ToList();
            }
        }

        public Category GetCategory(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Category.Find(ID);
            }
        }

        public void SaveCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Category.Add(category);
                context.SaveChanges();
            }
        }


        public void UpdateCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }



        public void DeleteCategory(int ID)
        {
            using (var context = new CBContext())
            {
                var category = context.Category.Find(ID);
                //alsoWorks// context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.Category.Remove(category);
                context.SaveChanges();
            }
        }

    }
}
