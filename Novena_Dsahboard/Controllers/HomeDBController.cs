using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Novena_Dsahboard.Models;
using Novena_Dsahboard.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Controllers
{
    

    public class HomeDBController : Controller
    {
       

        private readonly Novena_DsahboardContext dbContext;
        private readonly IHostingEnvironment webHostEnvironment;
      

        public HomeDBController(Novena_DsahboardContext context, IHostingEnvironment hostEnvironment)
        {
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Service()
        {
            var service = await dbContext.WebService.ToListAsync();
            return View(service);
        }



        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> New(WebServiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                WebService Webs = new WebService
                {
                    Heading = model.Heading,
                    Description = model.Description,
                    Picture = uniqueFileName
                };
                dbContext.Add(Webs);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Service));
            }
            return View();
        }

        private string UploadedFile(WebServiceViewModel model)
        {
            string uniqueFileName = null;

            if (model.Picture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Picture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

     

        

       














        public async Task<IActionResult> Casestudy()
        {
            var blog = await dbContext.Casestudy.ToListAsync();
            return View(blog);
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBlog(CasestudyViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFiles(model);

                Casestudy Blog = new Casestudy
                {
                    Title = model.Title,
                    Description = model.Description,
                    Image = uniqueFileName,
                    Date =model.Date
                };
                dbContext.Add(Blog);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Casestudy));
            }
            return View();
        }

        private string UploadedFiles(CasestudyViewModel model)
        {
            string uniqueFileName = null;

            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imgblog");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }





       









        public async Task<IActionResult> Event()
        {
            var evnt = await dbContext.Event.ToListAsync();
            return View(evnt);
        }

        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEvent(EventViewModel model)
        {
            if (ModelState.IsValid)
            {
                

                Event Evt = new Event
                {
                    
                    Title = model.Title,
                    Decsription = model.Decsription, 
                    Date = model.Date
                };
                dbContext.Add(Evt);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Event));
            }
            return View();
        }













        public async Task<IActionResult> Speaker()
        {
            var speaker = await dbContext.Speaker.ToListAsync();
            return View(speaker);
        }

        public IActionResult CreateSpeaker()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSpeaker(SpeakerViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Speaker Speak = new Speaker
                {
                    Name = model.Name,
                    Title = model.Title,

                    Decsription = model.Decsription,
                    Picture = uniqueFileName
                };
                dbContext.Add(Speak);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Speaker));
            }
            return View();
        }

        private string UploadedFile(SpeakerViewModel model)
        {
            string uniqueFileName = null;

            if (model.Picture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imgSpeaker");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Picture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        //public async Task<IActionResult> Product()
        //{
        //    var product = await dbContext.Product.ToListAsync();
        //    return View(product);


        //}
        //public IActionResult Product()
        //{

        //    if (TempData["Cart"] != null)
        //    {
        //        float x = 0;
        //        List<Cart> li2 = TempData["Cart"] as List<Cart>;

        //        foreach (var item in li2)
        //        {
        //            x += item.bill;

        //        }

        //        //TempData["total"] = x;

        //        TempData["total"] = JsonConvert.SerializeObject(x);
        //    }
        //    TempData.Keep();

        //    return View(dbContext.Product.OrderByDescending(x => x.Id).ToList());

        //}

        public IActionResult Product(string SearchText = "")
        {
            List<Product> Product;
            if (SearchText != "" && SearchText != null)
            {
                Product = dbContext.Product
                .Where(N => N.Title.Contains(SearchText))
                .ToList();


            }
            else
                Product = dbContext.Product.ToList();
            return View(Product);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFiles(model);

                Product Pro = new Product
                {
                    Title = model.Title,
                    ProImage = uniqueFileName,
                    Price = model.Price,
                    Description = model.Description,
                    Catagory = model.Catagory


                };
                dbContext.Add(Pro);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Product));
            }
            return View();
        }

        private string UploadedFiles(ProductViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imgProduct");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



        public ActionResult ChildCare(string searching = "Child Care")
        {
            var record = from s in dbContext.Product select s;

            record = record.Where(s => s.Catagory.Contains(searching));

            return View(record.ToList());
        }
        public ActionResult Diabetes(string searching = "Diabetes")
        {
            var record = from s in dbContext.Product select s;

            record = record .Where(s => s.Catagory.Contains(searching));

            return View(record.ToList());
        }
        public ActionResult AdultHealth(string searching = "Adult Health")
        {
            var record = from s in dbContext.Product select s;

            record = record.Where(s => s.Catagory.Contains(searching));

            return View(record.ToList());
        }
        public ActionResult ImmumeMedicine(string searching = "Immume Medicine")
        {
            var record = from s in dbContext.Product select s;

            record = record.Where(s => s.Catagory.Contains(searching));

            return View(record.ToList());
        }
        public ActionResult PainKillers(string searching = "Pain Killers")
        {
            var record = from s in dbContext.Product select s;

            record = record.Where(s => s.Catagory.Contains(searching));

            return View(record.ToList());
        }
        public ActionResult Antibiotics(string searching = "Antibiotics")
        {
            var record = from s in dbContext.Product select s;

            record = record.Where(s => s.Catagory.Contains(searching));

            return View(record.ToList());
        }

























        public async Task<IActionResult> Scientific()
        {
            var sci = await dbContext.Scientific.ToListAsync();
            return View(sci);
        }
        



        public IActionResult CreateScientific()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateScientific(ScientificViewModel model)
        {
            if (ModelState.IsValid)
            {
                string  uniqueFileName = UploadedFiles(model);

                Scientific Sci = new Scientific
                {
                    Title = model.Title,
                    ProImage = uniqueFileName,
                    Price = model.Price,
                    DiscountPrice = model.DiscountPrice,


                };
                dbContext.Add(Sci);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Scientific));
            }
            return View();
        }

        private string UploadedFiles(ScientificViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imgsci");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



        public List<Product> getAllProduct()
        {
            return dbContext.Product.ToList();
        }

        //GET DETAIL PRODUCT
        public Product getDetailProduct(int id)
        {
            var product = dbContext.Product.Find(id);
            return product;
        }




        public IActionResult addCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = getDetailProduct(id);

              

                List<Cart> listCart = new List<Cart>()
               {
                   new Cart
                   {
                       Product = product,
                    
                       qty = 1
                   }

               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == id)
                    {
                        dataCart[i].qty++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new Cart
                    {
                        Product = getDetailProduct(id),
                        qty = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return RedirectToAction(nameof(Product));

        }
        [Authorize]
        public IActionResult ListCart()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return RedirectToAction(nameof(Product));
        }
        [HttpPost]
        public IActionResult updateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].Product.Id == id)
                        {
                            dataCart[i].qty = quantity;
                        }

                        
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }


        public IActionResult deleteCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(actionName: "ListCart", controllerName: "HomeDB");
            }
            return RedirectToAction(actionName: "Product", controllerName: "HomeDB");
        }


















        //[HttpGet]
        //public ActionResult Addtocart(int? Id)
        //{

        //    Product p = dbContext.Product.Where(x => x.Id == Id).SingleOrDefault();
        //    return View(p);
        //}

        //List<Cart> li = new List<Cart>();


        //[HttpPost]


        //public ActionResult Addtocart(Product pi, string qty, int Id)
        //{
        //    Product p = dbContext.Product.Where(x => x.Id == Id).SingleOrDefault();

        //    Cart c = new Cart();
        //    c.productid = p.Id;
        //    c.price = p.Price;
        //    c.qty = Convert.ToInt32(qty);
        //    c.bill = c.price * c.qty;
        //    c.Productname = p.Title;
        //    if (TempData["Cart"] == null)
        //    {
        //        li.Add(c);
        //        //TempData["Cart"] = li;
        //        TempData["Cart"] = JsonConvert.SerializeObject(li);

        //    }
        //    else
        //    {
        //        List<Cart> li2 = TempData["Cart"] as List<Cart>;
        //        int flog = 0;
        //        foreach (var item in li2)
        //        {
        //            if (item.productid == c.productid)
        //            {
        //                item.qty += c.qty;
        //                item.bill += c.bill;
        //                flog = 1;

        //            }

        //        }
        //        if (flog == 0)
        //        {
        //            li2.Add(c);
        //        }
        //        //li2.Add(c);
        //        //TempData["Cart"] = li2;
        //        TempData["Cart"] = JsonConvert.SerializeObject(li2);
        //    }

        //    TempData.Keep();




        //    return RedirectToAction("Product");
        //}


        //    public ActionResult remove(int? id)
        //{
        //    List<Cart> li2 = TempData["Cart"] as List<Cart>;
        //    Cart c = li2.Where(x => x.productid == id).SingleOrDefault();
        //    li2.Remove(c);
        //    float h = 0;
        //    foreach (var item in li2)
        //    {
        //        h += item.bill;
        //    }

        //    //TempData["total"] = h;
        //    TempData["total"] = JsonConvert.SerializeObject(h);
        //    return RedirectToAction("checkout");
        //}



        //public ActionResult checkout()
        //{
        //    TempData.Keep();
        //    return View();
        //}

        //[HttpPost]

        //public ActionResult checkout(Order O)
        //{
        //    List<Cart> li = TempData["Cart"] as List<Cart>;
        //    Invoice iv = new Invoice();

        //    iv.in_date = System.DateTime.Now;
        //    iv.in_totalbill = (float)TempData["total"];

        //    dbContext.Invoice.Add(iv);
        //    dbContext.SaveChanges();

        //    foreach (var item in li)
        //    {
        //        Order od = new Order();
        //        od.o_fk_pro = item.productid;
        //        od.o_fk_invoice = iv.in_id;
        //        od.o_date = System.DateTime.Now;
        //        od.o_qty = item.qty;
        //        od.o_unitprice = (int)item.price;
        //        od.o_bill = item.bill;
        //        dbContext.Order.Add(od);
        //        dbContext.SaveChanges();




        //    }

        //    TempData.Remove("total");

        //    TempData.Remove("Cart");

        //    TempData["msg"] = "Transaction Complete.......";

        //    TempData.Keep();
        //    return RedirectToAction("Product");
        //}






























        public async Task<IActionResult> Department()
        {
            var dep = await dbContext.Department.ToListAsync();
            return View(dep);
        }


        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDepartment(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFiles(model);

                Department Dep = new Department
                {
                    Title = model.Title,
                    Image = uniqueFileName,
                   Description=model.Description,
                   DescriptionB=model.DescriptionB


                };
                dbContext.Add(Dep);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Department));
            }
            return View();
        }

        private string UploadedFiles(DepartmentViewModel model)
        {
            string uniqueFileName = null;

            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imgdep");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }









        public async Task<IActionResult> Doctor()
        {
            var doc = await dbContext.Doctor.ToListAsync();
            return View(doc);
        } 


        public IActionResult CreateDoctor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDoctor(DoctorViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFiles(model);

                Doctor Doc = new Doctor
                {
                    Title = model.Title,
                    Name= model.Name,
                    Dep=model.Dep,
                    Decsription=model.Decsription,
                    Picture= uniqueFileName



                };
                dbContext.Add(Doc);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Doctor));
            }
            return View();
        }

        private string UploadedFiles(DoctorViewModel model)
        {
            string uniqueFileName = null;

            if (model.Picture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imgdoc");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Picture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }






        













        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            

            return View();
        }

        public IActionResult Forms()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
       
    }
}
