using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGenesis
{
    internal interface IMutable
    {
        void Mutate(double mutationRate);
    }
}
