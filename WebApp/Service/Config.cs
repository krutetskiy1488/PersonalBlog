using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace WebApp.Service
{
    public class Config
    {
        public static string ConnectionString { get; set; }
        public static string Personal { get; set; }
        public static string PersonalPhone { get; set; }
        public static string PersonalPhoneShort { get; set; }
        public static string PersonalEmail { get; set; }
        public static string Instagram { get; set; }
        public static string Vk { get; set; } 
        public static string GitHub { get; set; }
    }
}
