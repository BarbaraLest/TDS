using PetCare.Common.ModelClasses;
using PetCare.Domain.ValueObjects;
using System;

namespace PetCare.Domain.Models
{
   public class OwnerModel : ModelClass
    {
        #region Properties

        public Guid OwnerID { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public Telephone Telephone { get; private set; }
        #endregion

        #region Constructors
        public OwnerModel(Name name, Email email, Address address, Telephone telephone, Guid? ownerID = null)
        {
            Name = name;
            Email = email;
            Address = address;
            Telephone = telephone;
            OwnerID = ownerID ?? Guid.NewGuid();
        }


        #endregion


    }
}
