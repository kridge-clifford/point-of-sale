using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Utilities
{
    public class Functions
    {
        private static Random random = new Random();
        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public static string CreateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray()).ToLower();
        }

        public static string RandomNumbers(int length)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray()).ToLower();
        }

        public static bool SaveImage(Image img, String path)
        {
            try
            {
                Console.WriteLine(path);
                img.Save(path);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public static string SanitizeString(string data)
        {
            char[] explodedData = data.Trim().ToCharArray();
            string sanitizedString = "";
            foreach (char element in explodedData)
            {
                if (element.ToString().Equals("\"")) { }
                else if (element.ToString().Equals("{")) { }
                else if (element.ToString().Equals("}")) { }
                else if (element.ToString().Equals("\\")) { }
                else if (element.ToString().Equals("&")) { }
                else if (element.ToString().Equals("?")) { }
                else if (element.ToString().Equals("$")) { }
                else if (element.ToString().Equals(";")) { }
                else
                {
                    sanitizedString = sanitizedString + element.ToString();
                }
            }
            return sanitizedString;
        }

   
        public static string GetSignedNumber(int number)
        {
            if (number.ToString().Length == 1)
            {
                return "000" + number.ToString();
            }
            else if (number.ToString().Length == 2)
            {
                return "00" + number.ToString();
            }
            else if (number.ToString().Length == 3)
            {
                return "0" + number.ToString();
            }
            else
            {
                return number.ToString();
            }
        }

        public static bool CheckWhiteSpace(string data)
        {
            char[] characters = data.ToCharArray();
            foreach (char value in characters)
            {
                if (value.ToString().Equals(" "))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public static string getCentimeter(double inches)
        {
            Console.WriteLine(inches.ToString());
            return (inches * 2.54).ToString();
        }

        public static string getFeetInches(double centimeter)
        {
            double inches = centimeter * 0.3937008;
            double calcInches = inches;
            int feet = 0;
            while (calcInches > 12)
            {
                feet++;
                calcInches = calcInches - 12;
            }

            double remainder = inches - (feet * 12);
            return feet.ToString() + "-" + Math.Round(remainder).ToString();
        }

        public static bool CheckIfImageIsValid(string path)
        {
            try
            {
                Image test = Image.FromFile(path);
                test.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Int32 GetAge(int yearValue, int monthValue, int dayValue)
        {
            try
            {
                var today = DateTime.Today;

                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (yearValue * 100 + monthValue) * 100 + dayValue;

                return (a - b) / 10000;
            }
            catch
            {
                return 0;
            }
        }
    }
}
