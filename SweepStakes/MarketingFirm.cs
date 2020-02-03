using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        ISweepStakesManager manager;

        public MarketingFirm(ISweepStakesManager manager) 
        {
            this.manager = manager;




        
        }
        public void SweepStakes() 
        {
            SweepStakes sweepStakes = new SweepStakes();
            manager.InsertSweepStakes(sweepStakes);
        
        }
           
        



            

    }
}
