using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TOBShelter.utils
{
    public static class DbUtil
    {
        public static bool CheckSqlInjection(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value));

            string[] subs = value.Split(' ');
            if (subs.Length > 1)
                return true;

            if (Regex.IsMatch(value, "^[0-9]+$"))
                return true;

            return false;
        }
    }
}
