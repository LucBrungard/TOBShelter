using System.Text.RegularExpressions;

namespace TOBShelter.Utils
{
    public static class RegexUtil
    {
        public readonly static Regex RegexNom = new Regex("^[A-Za-zÀ-ÖØ-öø-ÿ]+([-][A-Za-zÀ-ÖØ-öø-ÿ]+)*$");
        public readonly static Regex RegexAdresse = new Regex("^[A-Za-z0-9\\s]*$"); // TODO trouver une bonne regex d'adresse
        public readonly static Regex RegexTel = new Regex("^0[1-9][0-9]{8}$");
        public readonly static Regex RegexCodePostal = new Regex("^[0-9]{5}$");
        public readonly static Regex RegexEmail = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
    }
}