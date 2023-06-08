using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products;

        public FakeProductRepository()
        {
            _products = new()
            {
                new Product{Id=1, Name="Casper", Description="Excalibur G870.1245-DXA0X-B Intel Core i5-12450H 32GB RAM 2TB NVME SSD 6GB RTX4050", Price=25499, 
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty785/product/media/images/20230317/13/306057445/889207345/1/1_org_zoom.jpg", CategoryId = 1},
                new Product{Id=2, Name="Lenovo", Description="Ideapad1/Celeron N4120/4GB Ram/128GB emmc /15.6\"/Win 11 82V7005MTX", Price=5899,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty596/product/media/images/20221109/18/210958980/618235279/1/1_org_zoom.jpg", CategoryId = 1},
                new Product{Id=3, Name="Xiaomi", Description="Redmi Note 12 Pro 8gb/256gb Gri 6.7 inç Kamera : 100-120 MP ( Xiaomi Türkiye Garantili)", Price=9799 , 
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty821/product/media/images/20230410/17/321680406/907364554/1/1_org_zoom.jpg", CategoryId = 3},
                new Product{Id=4, Name="Apple", Description="iPad 9. Nesil 64 GB 10.2\" Wi-Fi Gümüş Tablet (Apple Türkiye Garantili) 10.2 inç RAM : 3 Gb ", Price=7899 , 
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty393/product/media/images/20220412/18/89375925/257521321/1/1_org_zoom.jpg", CategoryId = 2},
                new Product{Id=5, Name="XİAOMİ", Description="X4 Pro 5G 6GB Ram 128GB Hafıza Type-C Şarj Girişli Mavi (POCO Türkiye Garantili)", Price=7999 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty497/product/media/images/20220802/12/153562667/533730044/1/1_org_zoom.jpg", CategoryId =3},
                new Product{Id=6, Name="Apple", Description="Macbook Air 13'' M1 8gb 256gb Ssd Uzay Grisi Dizüstü Bilgisayar MGND3TU/A", Price=20799,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty454/product/media/images/20220614/15/125590297/117920493/1/1_org_zoom.jpg", CategoryId = 1},
                new Product{Id=7, Name="Lenovo", Description="Tab M10 TB-X306F 4GB + 64GB 10.1\" Wi-Fi Gri Tablet - ZA6W0121TR (Türkiye Garantili)", Price=3999,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty100/product/media/images/20210407/18/78489342/161622270/1/1_org_zoom.jpg", CategoryId = 2},
                new Product{Id=8, Name="Samsung", Description="Galaxy A32 6 Gb Ram ,128 GB Hafıza Kamera : 60-80 Mp  Siyah Cep Telefonu (Türkiye Garantili)", Price=7398 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty542/product/media/images/20220927/13/180289100/165513649/3/3_org_zoom.jpg", CategoryId = 3},
                new Product{Id=9, Name="Xiaomi", Description="X4 Pro 5G 8 GB+256 GB Sarı Cep Telefonu (Xiaomi Türkiye Garantili)", Price=8999 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty500/product/media/images/20220804/13/154569467/535634122/1/1_org_zoom.jpg", CategoryId = 3},
                new Product{Id=10, Name="Lenovo", Description="Tab M10 Plus TB-X606F 4GB + 128GB 10.3\" Wi-Fi Gri Tablet - ZA6H0025TR (Türkiye Garantili)", Price=5199 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty161/product/media/images/20210816/16/119077421/212168993/1/1_org_zoom.jpg", CategoryId =2},                
                new Product{Id=11, Name="Asus", Description="X415ma-ek385w/cel N4020/4gb Ram/128gb Ssd/14\"/wın11 Convertible Laptop Gri", Price=5249,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty510/product/media/images/20220819/12/162768045/547854821/1/1_org_zoom.jpg", CategoryId = 1},
                new Product{Id=12, Name="Hometech", Description="Alfa-10tb 4 Gb Ram 64gb Hafıza 10 inç Ips Tablet + Klavye + Kılıf 227", Price=2959,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty3/product/media/images/20201020/9/17534411/95296587/1/1_org_zoom.jpg", CategoryId = 2},
                new Product{Id=13, Name="Apple", Description="iPad Mini 6. Nesil 64 GB 8.3\" Wi-Fi Uzay Grisi Tablet (Apple Türkiye Garantili) MK7P3TU/A", Price=13199 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty205/product/media/images/20211020/17/152949438/269538780/0/0_org_zoom.jpg", CategoryId = 2},
                new Product{Id=14, Name="Acer", Description="Nitro 5 Intel Core i5-12500H 8GB 512GB SSD 4GB RTX3050Ti Linux 15.6'' FHD Gaming Laptop", Price=17498 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty823/product/media/images/20230412/16/323220173/641857663/2/2_org_zoom.jpg", CategoryId = 1},
                new Product{Id=15, Name="Samsung", Description="Sinada Samsung E1205 Siyah Kamerasız Cep Telefonu (RESMİ BTK KAYITLI) E1205yeni", Price=769 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty707/product/media/images/20230127/12/267618211/842073841/1/1_org_zoom.jpg", CategoryId =3},            
                new Product{Id=16, Name="Alcatel", Description="Alcatel 1t 10 2020 Wifi Bluetooth Klavyeli Kılıf Tablet 16 Gb Hafıza 1 Gb Ram Kamera : 5 Mp, Siyah", Price=1659,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty376/product/media/images/20220331/12/79598381/108959068/1/1_org_zoom.jpg", CategoryId = 2},
                new Product{Id=17, Name="Casper", Description="Nirvana C370.4020-4C00B Intel Celeron N4020 4GB/120GB SSD Windows 11 Home 15.6\" HD", Price=5399 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty541/product/media/images/20220927/8/180205626/580426848/1/1_org_zoom.jpg", CategoryId = 1},
                new Product{Id=18, Name="Reeder", Description="Reeder S19 Max 4 Gb Ram 32 Gb Hafıza Usb Type-C Şarj Girişli 3500-4000mAH Batarya, Yeşil", Price=2259 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty769/product/media/images/20230309/19/299880842/881443637/1/1_org_zoom.jpg", CategoryId = 3},
                new Product{Id=19, Name="Huawei", Description="Matebook D15/ I5-1155g7 Işlemci 8gb/256gb 15.6 Inç/ Win 11 Laptop Mistik Gümüş ", Price=11155 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty743/product/media/images/20230222/12/286675166/865121440/1/1_org_zoom.jpg", CategoryId =1},               
                new Product{Id=20, Name="MSI", Description="MSI TITAN GT77 12UHS-036TR I9-12900HXRTX3080TI GDDR6 16Gb/2TB 17.3 UHD 120Hz W11", Price=164999,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty455/product/media/images/20220614/13/125537962/498608765/1/1_org_zoom.jpg", CategoryId = 1 },
                new Product{Id=21, Name="Nokia", Description="SenalStore Nokia 1200 1500mAH Batarya, Ön Kamera : 1 Mp, Kamera Çözünürlüğü : 5 Mp", Price=455,
                                  ImageUrl="https://cdn.dsmcdn.com/mnresize/1200/1800/ty757/product/media/images/20230302/2/293144496/856744795/1/1_org_zoom.jpg", CategoryId = 3 },
                new Product{Id=22, Name="Vorcom", Description="Vorcom 10.1 Inc 4 Gb Ram 64 Gb Hafıza 1280*800 Ips 8 Çekirdek Işlemcili  Mavi Tablet QuartzLITE", Price=2299 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty693/product/media/images/20230120/1/261777943/696047822/1/1_org_zoom.jpg", CategoryId = 2},
                new Product{Id=23, Name="Apple", Description="Apple iPhone 13 128 GB Yıldız Işığı Cep Telefonu (Apple Türkiye Garantili)", Price=28498 ,
                                  ImageUrl = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty814/product/media/images/20230406/11/319331216/250484948/1/1_org_zoom.jpg", CategoryId = 3}
            };
        }
        public Product? Get(int id)
        {
            return _products.Find(x => x.Id == id);
        }

        public IList<Product?> GetAll()
        {
            return _products;
        }

        public Task<IList<Product?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();

        }
        public IEnumerable<Product> GetProductByCategory(int categoryId)
        {

            return _products.Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAllWithPredicate(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
