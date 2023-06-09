﻿using System.Text.RegularExpressions;

namespace TOBShelter.Utils
{
    public static class RegexUtil
    {
        public readonly static Regex RegexNom = new Regex("^[A-Za-zÀ-ÖØ-öø-ÿ]+([-][A-Za-zÀ-ÖØ-öø-ÿ]+)*$");
        public readonly static Regex RegexAdresse = new Regex("^[A-Za-z0-9\\s]*$"); // TODO trouver une bonne regex d'adresse
        public readonly static Regex RegexPhoneNumber = new Regex("^0[1-9][0-9]{8}$");
        public readonly static Regex RegexPostalCode = new Regex("^((01)|([1-9][0-9]))[0-9]{3}$");
        public readonly static Regex RegexEmail = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
        public readonly static Regex RegexWeight = new Regex("^(\\d+)(\\.\\d{1,2})?(kg|g)$");
    }
}