using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;


namespace BakeryShop.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BakeryShopContext _bakeryShopContext;
        public OrderModel(BakeryShopContext bakeryShopContext) => this._bakeryShopContext = bakeryShopContext;
        public Product product { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty,EmailAddress,Required(ErrorMessage ="Please Enter A Valid Email"),Display(Name ="Enter Your Email Adress")]
        public string OrderEmail { get; set; }

        [BindProperty, Required(ErrorMessage = "Please Enter Your Shipping Adrees"), Display(Name = "Shipping Adress")]
        public string OrderShipping { get; set; }

        [BindProperty,Display(Name ="Quantity")]
        public int OrderQuantity { get; set; }
        public async Task OnGetAsync() => product = await _bakeryShopContext.Products.FindAsync(Id);

        public async Task<IActionResult> OnPostAsync()
        {
            product = await  _bakeryShopContext.Products.FindAsync(Id);
            if(ModelState.IsValid)
            {
                //var body = $"<p>Thank you , We recevied your order for {OrderQuantity} peices of {product.ProductName} </p>" +
                //           $"<p>Your Adress Is : {OrderShipping}</p>" +
                //           $"<p>Yor Total Price Is : {OrderQuantity * product.ProductPrice}</p>" +
                //           $"<p><b>Your Order Will Be Delevered Within 60 Minutes</b></p>";
                //using(var smtp = new SmtpClient())
                //{
                //    //var googleCredential = new NetworkCredential
                //    //{
                //    //    UserName = $"shehab.ahmed@jadeegypt.com",
                //    //    Password = $"Dat64559"
                //    //};
                //    //smtp.Credentials = googleCredential;
                //    smtp.Host = "smtp.freesmtpservers.com";
                //    smtp.Port = 25;
                //    smtp.EnableSsl = true;
                //    var meesage = new MailMessage();
                //    meesage.To.Add(OrderEmail);
                //    meesage.Subject = "Order Confirmation";
                //    meesage.Body = body;
                //    meesage.IsBodyHtml = true;
                //    meesage.From = new MailAddress("shehab.eldeen.ahmed427797@gmail.com");
                //    await smtp.SendMailAsync(meesage);
                //}
                return RedirectToPage("Ordersuccess");
            }
            return Page();
        }

    }
}
