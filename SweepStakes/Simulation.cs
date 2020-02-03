using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        public ISweepStakesManager CreatingMarketingFirmWithManager() 
        {
            Console.WriteLine("Would you prefer stack or queue to manage the sweepstakes. ");
            string value = Console.ReadLine();
            ISweepStakesManager manager = null;
            if (value == "Stack")
            {
                manager = new SweepStakesStackManager();
            }
            else if (value == "queue") 
            {
                manager = new SweepStakesQueueManager();
            
            }
            return manager;

        }
    }
}
