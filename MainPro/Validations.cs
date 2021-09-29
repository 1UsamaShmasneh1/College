using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainPro
{
    public static class Validations
    {
        public static bool ValidateId(this string id)
        {
            int sum = 0;
            int counter = 1;
            string temp;
            string ch;
            if (id.Length == 9)
            {
                foreach (char cha in id)
                {
                    ch = Convert.ToString(cha);
                    if (counter % 2 == 0)
                    {
                        if (Convert.ToInt32(ch) * 2 > 9)
                        {
                            temp = Convert.ToString(Convert.ToInt32(ch) * 2);
                            sum += Convert.ToInt32(Convert.ToString(temp[0])) + Convert.ToInt32(Convert.ToString(temp[1]));
                        }
                        else
                        {
                            sum += Convert.ToInt32(ch) * 2;
                        }
                    }
                    else
                    {
                        sum += Convert.ToInt32(ch);
                    }
                    counter++;
                }
                if (sum % 10 == 0)
                    return true;
            }
            return false;
        }
        public static bool ValidateName(this string name)
        {
            Regex regex = new Regex(@"^\D{2,20}");
            return regex.IsMatch(name);
        }
        public static bool ValidatePhoneNumber(this string phoneNumber)
        {
            Regex regex = new Regex(@"^0[0-9]{8,9}$");
            return regex.IsMatch(phoneNumber);
        }
        public static bool ValidateEmail(this string email)
        {
            var regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        }
    }
}
