using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterDel1
{
    public abstract class House
    {
        public string HouseGhost;
        public string Mascot;
        public string Password;
        public string OldPassword;
        public string NewPassword;
        public List<Wizard> Members = null;

        public bool Isvowel(char characterVowel)
        {
            string vokaler = "aouåeiyåöäAOUÅEIYÅÖÄ";
            bool theVowels = false;
            foreach (char vowel in vokaler)
            {
                {
                    if (vowel == characterVowel)
                    {
                        theVowels = true;
                        break;
                    }
                }


            }
            return theVowels;
        }

        public bool IsKonsonant(char characterKonsonant)
        {
            string konsonanter = "bcdfghjklmnpqrstvwxyBCDFGHJKLMNPQRSTVWXY";
            bool theKonsonant = false;
            foreach (char konsonant in konsonanter)
            {
                if (konsonant == characterKonsonant)
                {
                    theKonsonant = true;
                    break;
                }
            }
            return theKonsonant;
        }
        public bool SetNewPassword(string OldPassword, string NewPassword) // Byte av lösenord.
        {
            bool passwordchange;
            if (CheckPasswordFormat(NewPassword) == true)
            {
                Password = NewPassword;
                passwordchange = true;
            }
            else
            {
                passwordchange = false;
            }


            return passwordchange;

        }

        public bool NumberOfLett(string NewPassword)
        {
            bool correctLetters;
            int lettCount = 0;
            foreach (char lett in NewPassword)
            {
                lettCount++;
            }
            if (lettCount == 5)
            {
                correctLetters = true;
            }
            else
            {
                correctLetters = false;
            }
            return correctLetters;
        }

        public bool CheckPasswordFormat(string NewPassword) // kontrollernar om lösenordet är av rätt format.
        {

            bool hasCorrectPassword;

            if (NumberOfLett(NewPassword) && Isvowel(NewPassword[0]) && IsKonsonant(NewPassword[4]) == true)
            {
                hasCorrectPassword = true;
            }
            else
            {
                hasCorrectPassword = false;
            }
            return hasCorrectPassword;
        }
    }
}
