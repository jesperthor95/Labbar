using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterDel1
{
    public class Slytherin : House
    {
        public Slytherin()
        {
            HouseGhost = "Blodige Baronen";
            Mascot = "Orm";
            Members = null;
            Password = "Pure-Blood";
            OldPassword = "Pure-Blood";
            NewPassword = "trnnnnnt";
        }

        public bool SetNewPasswordSlyt(string OldPassword, string NewPassword) // Byte av lösenord.
        {
            bool passwordchange;
            if (CheckPasswordFormatSlyt(NewPassword) == true)
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
        public bool NumberOfLettSlyt(string NewPassword)
        {
            bool correctLetters;
            int lettCount = 0;
            foreach (char lett in NewPassword)
            {
                lettCount++;
            }
            if (lettCount == 8)
            {
                correctLetters = true;
            }
            else
            {
                correctLetters = false;
            }
            return correctLetters;
        }


        public bool CheckPasswordFormatSlyt(string NewPassword) // kontrollernar om lösenordet är av rätt format.
        {
            bool hasCorrectPassword;

            if (NumberOfLettSlyt(NewPassword) && IsKonsonant(NewPassword[0]) && IsKonsonant(NewPassword[7]) == true)
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
