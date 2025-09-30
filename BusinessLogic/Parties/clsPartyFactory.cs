using System;

namespace BusinessLogic.Parties
{
    public static class clsPartyFactory
    {
        public static clsParty GetFromDB(int partyID, clsParty.enPartyCategory category)
        {
            if (partyID < 1)
            {
                return null;
            }

            switch (category)
            {
                case clsParty.enPartyCategory.Person:
                    return clsPerson.FindByPartyID(partyID);
                case clsParty.enPartyCategory.Organization:
                    return clsOrganization.FindByPartyID(partyID);
                default:
                    return null;
            }
        }

    }
}
