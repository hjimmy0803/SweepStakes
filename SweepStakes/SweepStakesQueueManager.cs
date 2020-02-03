using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesQueueManager: ISweepStakesManager
    {
        Queue<SweepStakes> sweepStakesQueueManager = new Queue<SweepStakes>();



        public SweepStakes GetSweepStakes() 
        {
            return sweepStakesQueueManager.Dequeue();
        
        }

        public void InsertSweepStakes(SweepStakes sweepStakes) 
        {
            sweepStakesQueueManager.Enqueue(sweepStakes);
        
        }



        


    
    }
}
