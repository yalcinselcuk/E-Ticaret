using ProductApp.Dto.Responses;
using ProductApp.Entities;

namespace ProductApp.Mvc.Models
{
    public class ProductCollection
    {
        public List<ProductItem> ProductItems { get; set; } = new List<ProductItem>();

        public void ClearAll()
        {
            ProductItems.Clear();
        }
        public decimal TotalCoursePrice()
        {
            return ProductItems.Sum(item => (decimal)item.Product.Price * item.Quantity);
        }
        public int TotalCoursesCount()
        {
            return ProductItems.Sum(product => product.Quantity);
        }
        //silme işlemi yok, sen yapacaksın

        //hiç eklenmemişse ekle
        //eklenmişse adeti artır
        public void AddNewCourse(ProductItem productItem)
        {
            var exists = ProductItems.FirstOrDefault(course => course.Product.Id == productItem.Product.Id); // var mı yok mu diye kontrol ediyoruz
            if (exists != null)//eğer exists doğruysa 
            {
                //var existingCourse = CourseItems.FirstOrDefault(course => course.Course.Id == courseItem.Course.Id);
                exists.Quantity += productItem.Quantity;//var olanın adetini yeni gelenin adedi kadar artır
            }
            else
            {
                ProductItems.Add(productItem);
            }
        }


    }

    public class ProductItem
    {
        public ProductDisplayResponse Product { get; set; }
        public int Quantity { get; set; }
        public bool? ApplyCoupon { get; set; }//kupon uygulanabilirliği

    }
}
