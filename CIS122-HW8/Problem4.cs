//Ryan Alghamdi
//April 16

//HW8 problem 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW8
{
    public class RecentCounter
    {
        private Queue<int> requests = new Queue<int>();

        public RecentCounter()
        {
            
        }

        public int Ping(int t)
        {
            requests.Enqueue(t);

            // Remove requests older than 3000ms
            while (requests.Peek() < t - 3000)
            {
                requests.Dequeue();
            }

            return requests.Count; // Return the number of requests in the last 3000ms
        }
    }
}


/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */