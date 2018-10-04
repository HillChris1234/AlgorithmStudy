using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneSeats
{
    class AirplaneSeats
    {
        static int solution(int N, string S)
        {
            Hashtable seats = new Hashtable();

            for (int x = 1; x <= N; x++) //Create a map of the plane (seats A-K for N rows) with empty seats
            {
                seats.Add(x + "A", false);
                seats.Add(x + "B", false);
                seats.Add(x + "C", false);

                seats.Add(x + "D", false);
                seats.Add(x + "E", false);
                seats.Add(x + "F", false);
                seats.Add(x + "G", false);

                seats.Add(x + "H", false);
                seats.Add(x + "J", false);
                seats.Add(x + "K", false);
            }

            string[] reserved = S.Split(' ');
            foreach (string seat in reserved) //Populate the plane map with the appropriate reservations
            {
                seats[seat] = true;
            }

            int totalFamilies = 0;
            for (int x = 1; x <= N; x++) //Go through each row on the plane to see how many families can fit on each row.
            {
                int availRow = 3; //There are 3 opportunities to seat a family of 3 on each row.
                if ((bool)seats[x + "A"] || (bool)seats[x + "B"] || (bool)seats[x + "C"]) //If there are any reserved seats on the port side, that takes away one grouping.
                {
                    availRow--;
                }
                if ((bool)seats[x + "H"] || (bool)seats[x + "J"] || (bool)seats[x + "K"]) //If there are any reserved seats on the starboard side, that takes away another grouping.
                {
                    availRow--;
                }
                if ((bool)seats[x + "E"] || (bool)seats[x + "F"]) //If either of the middle 2 seats are taken...
                {
                    availRow--;
                }
                else if ((bool)seats["D"] && (bool)seats["G"]) //OR, if both side seats in the middle are taken, that takes away the third group.
                {
                    availRow--;
                }
                totalFamilies += availRow; //Add the groupings available for this row to the total number for all rows
            }

            return totalFamilies;
        }
    }
}
