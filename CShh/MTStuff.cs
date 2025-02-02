using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShh
{
    class MTStuff
    {

        private bool started
        { get; set; }

        public MTStuff()
        {
            Console.WriteLine($"Production line pool running: {this.started}"); // before init
            this.started = true;
            Console.WriteLine($"Production line pool running: {this.started}"); // after
            Console.WriteLine("eyo from the constructor btw");
        }

        public async Task<int> SimulateSomethingIG(int lineID)
        {
            Console.WriteLine($"Production line(????): {lineID}\n-Running: {this.started}\n"); // oooh this.... <- i know this. 
            await Task.Delay(2000); // look at your phone after one part done method (i guess we doin circles now spirit lol)
            int unitsProduced = new Random().Next(700, 1001);
            Console.WriteLine($"Production line(?!?!): {lineID}\n-Running: {this.started}\n-Produced: {unitsProduced} units of seating lmao\n");
            return unitsProduced;
        }

        public async Task RunSomethingIG()
        {
            int result = await SimulateSomethingIG(1);
            Console.WriteLine($"G-Units: {result}");
        }
    }
    
}
