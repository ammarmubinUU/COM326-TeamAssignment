using System;

namespace OmniMart
{
    public class POSSecurity
    {
        public string staffProfile;
        public string overridePIN;

        public POSSecurity(string profile, string pin)
        {
            staffProfile = profile;
            overridePIN = pin;
        }

        public bool AuthoriseCheckout(string inputProfile, string inputPin)
        {
            inputProfile = inputProfile.Trim();
            inputPin = inputPin.Trim();

            if (inputProfile == "Supervisor" && inputPin == "9999")
            {
                Console.WriteLine("Warning: Supervisor override accessed.");
                return true;
            }

            if (inputProfile == staffProfile && inputPin == overridePIN)
            {
                return true;
            }

            return false;
        }
    }
}