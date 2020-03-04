using PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index()
        {
            return View();
        }
        // GET: A propos
        public ActionResult A_propos()
        {
            return View();
        }

        // GET: Contact
        [HttpPost]
        public ActionResult Contact()
        {
            //List<message> messages = Session["messages"] as List<message>;
            //if (messages == null)
            //{ messages = new List<message>(); }

            //message m = new message();
            //m.mail = M.mail;
            //m.objet = M.objet;
            //m.msg = M.msg;

            //messages.Add(m);
           
            return View();
        }

        public ActionResult ContactPMS()
        {
            
            return View();
        }

        public ActionResult PremiumSurveillance()
        {

            return View();
        }

        // GET: HSE
        public ActionResult Service_HSE()
        {
            return View();
        }

        // GET: Hebergement
        public ActionResult Service_Hebergement()
        {
            return View();
        }

        // GET: EM
        public ActionResult Service_EM()
        {
            return View();
        }

        public ActionResult Service_Navette()
        {
            return View();
        }

        // GET: Gardinnage
        public ActionResult Service_Buvette()
        {
            return View();
        }

        // GET: Jardinage
        public ActionResult Service_Jardinage()
        {
            return View();
        }

        // GET: Peinture industrielle
        public ActionResult Service_Peinture_industrielle()
        {
            return View();
        }


        // GET: Dératisation
        public ActionResult Service_Dératisation()
        {
            return View();
        }

        // GET: Restauration
        public ActionResult Service_Restauration()
        {
            return View();
        }

        // GET: Accueil/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accueil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accueil/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accueil/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accueil/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accueil/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accueil/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult ContactPMS(message M)
        {
            List<message> messages = Session["messages"] as List<message>;
            if (messages == null)
            { messages = new List<message>(); }

            message m = new message();
            m.mail = M.mail;
            m.objet = M.objet;
            m.msg = M.msg;
            m.nom = M.nom;
            messages.Add(m);
            //*****************************************
            //1:eli chtabath bih: 2li chtabathlou
            MailMessage mailMessage = new MailMessage("contactpms2012@gmail.com", "infopms2012@gmail.com");
            mailMessage.Subject = m.objet;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = string.Format("<html><head></head><body><b>  Mail de la personne: </b> " + m.mail + "<br> <b> Nom de la personne :</b>" + m.nom + "<br> <b> Message : <br></b> " + m.msg + "</body></html>");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "contactpms2012@gmail.com",
                Password = "pms2019."
            };
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;



            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
            return RedirectToAction("ContactPMS");
        }



        public ActionResult envoiMail()
        {
            //List<message> messages = Session["messages"] as List<message>;
            //if (messages == null)
            //{ messages = new List<message>(); }

            //message m = new message();
            //m.mail = M.mail;
            //m.objet = M.objet;
            //m.msg = M.msg;

            //messages.Add(m);


            //SendMail();

            return RedirectToAction("ContactPMS");
        }


        public ActionResult SERGAZ()
        {
            return View();
        }

        public ActionResult CTKCP()
        {
            return View();
        }

        public ActionResult SEREPT()
        {
            return View();
        }

        public ActionResult Gallerie()
        {
            return View();
        }

        public ActionResult Avis()
        {
            return View();
        }

    }

   


}
