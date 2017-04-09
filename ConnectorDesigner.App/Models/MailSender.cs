using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectorDesigner.App.Models
{
    public class MailSender
    {
        [Required(ErrorMessage =" *Email is required"), Display(Name="Receiver Email: ")]
        public string RecipentEmail { get; set; }

        [Required(ErrorMessage =" *Please type a message"), Display(Name = "Message : ")]
        public string Message { get; set; }
    }
}