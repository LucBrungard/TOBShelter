using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed
{
    internal abstract class Identity
    {
        private protected IdentityTitle _title;
        private protected string _name;

        internal virtual IdentityTitle Title
        {
            get { return _title; }
            set { _title = value; }
        }

        internal string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Can't be null or empty", nameof(_name));
                _name = value;
            }
        }

        private protected Identity(string name)
        {
            Name = name;
        }
    }

    internal class Physical : Identity
    {
        private string _firstName;

        internal override IdentityTitle Title
        {
            get { return base.Title; }
            set
            {
                if (!(value is IdentityTitle.M) && !(value is IdentityTitle.MME))
                    throw new ArgumentException($"Should be of type {IdentityTitle.M} or {IdentityTitle.MME}", nameof(_title));
                base.Title = value;
            }
        }

        internal string FirstName
        {
            get { return _firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Can't be null or empty", nameof(_firstName));
                _firstName = value;
            }
        }

        internal Physical(IdentityTitle title, string name, string firstName) : base(name)
        {
            Title = title;
            FirstName = firstName;
        }
    }

    internal class Society : Identity
    {
        internal override IdentityTitle Title
        {
            get { return base.Title; }
            set
            {
                if (!(value is IdentityTitle.SOCIETE))
                    throw new ArgumentException($"Should be of type {IdentityTitle.SOCIETE}", nameof(_title));
                base.Title = value;
            }
        }

        internal Society(IdentityTitle title, string name) : base(name)
        {
            Title = title;
        }
    }
}