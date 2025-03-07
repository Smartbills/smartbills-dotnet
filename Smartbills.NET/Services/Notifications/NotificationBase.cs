using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Notifications
{
    public class NotificationBase
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Body { get; set; }
        public string Sms { get; set; }
        public object Data { get; set; }

        public string EmailTemplateName { get; set; }
        public object EmailTemplateData { get; set; }
    }
}
