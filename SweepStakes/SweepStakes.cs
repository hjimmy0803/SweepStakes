using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        public Dictionary<int, Contestant> contestants= new Dictionary<int, Contestant>();
        string name;
        string Name;
        public int counter;


        public SweepStakes(string name) 
        {
            this.name = name;
        
        }

        

        public void RegisterContestant(Contestant contestant) 
        {
            contestant.regristrationNumber = UserInterface.SetRandomRegistrationNumber();
            contestant.firstName = UserInterface.SetFirstName();
            contestant.lastName = UserInterface.SetLastName();
            contestant.emailAddress = UserInterface.SetEmailAddress();
            contestants.Add(counter, contestant);
            counter++;
        
        } 
        public Contestant PickWinner(Dictionary<int, Contestant> contestants) 
        {
            Random number = new Random();
            int winningNumber;
            


                winningNumber = number.Next(0,counter);

                foreach (KeyValuePair<int, Contestant>  contestant in contestants)

                {

                    if (contestant.Key == winningNumber)

                    {

                        return contestant.Value;

                    }

                }

                return null ;

        }
        public void PrintContestantInfo(Contestant contestant) 
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.regristrationNumber);
            Console.ReadLine();
        
        }

    }
}
