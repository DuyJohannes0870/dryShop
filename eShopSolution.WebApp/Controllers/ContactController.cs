using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.WebApp.Models;
using System.Net.Mail;

namespace eShopSolution.WebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailContent em)
        {
            string name = em.Name;
            string subject = em.Subject;
            string body = em.Body;
            MailMessage mm = new MailMessage();
            mm.To.Add("bizz432000@gmail.com");
            mm.Subject = subject;
            mm.Body = "Họ Tên khách hàng: ".ToUpper() + name + Environment.NewLine + "Nội dung phản hồi từ Khách hàng: ".ToUpper() + Environment.NewLine+ body;
            mm.From = new MailAddress("bizz432000@gmail.com");
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("bizz432000@gmail.com", "duy0973849549");
            smtp.Send(mm);
            ViewBag.message = "Gửi phản hồi thành công ";
            return View();
        }
    }
}
