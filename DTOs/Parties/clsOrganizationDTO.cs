using System;

namespace DTOs.Parties
{
    public class clsOrganizationDTO : clsPartyDTO
    {
        public int OrganizationID { get; set; }
        public int ContactPersonID { get; set; }

        public clsOrganizationDTO() { }

        public clsOrganizationDTO(int organizationID, int contactPersonID)
        {
            OrganizationID = organizationID;
            ContactPersonID = contactPersonID;
        }

    }
}
