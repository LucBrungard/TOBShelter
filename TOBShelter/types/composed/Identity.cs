using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed
{
    internal abstract class Identity
    {
        private protected IdentityTitle _title;
    }

    internal class Physical : Identity
    {
        private string _name;
        private string _firstName;

        internal Physical(IdentityTitle title, string name, string firstName)
        {
            if (!(title is IdentityTitle.M) || !(title is IdentityTitle.MME))
                throw new ArgumentException($"Should be of type {IdentityTitle.M} or {IdentityTitle.MME}", nameof(title));
            _title = title;
            _name = name;
            _firstName = firstName;
        }
    }

    internal class Society : Identity
    {
        private string _name;

        internal Society(IdentityTitle title, string name)
        {
            if (!(title is IdentityTitle.SOCIETE))
                throw new ArgumentException($"Should be of type {IdentityTitle.SOCIETE}", nameof(title));
            _title = title;
            _name = name;
        }
    }
}