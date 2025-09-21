using System;

namespace DTOs
{
    public class clsOrganizationDTO : clsPartyDTO
    {
        public int ContactPersonID { get; set; }

        public clsOrganizationDTO() { }

        public clsOrganizationDTO(int contactPersonID)
        {
            ContactPersonID = contactPersonID;
        }

    }
}
