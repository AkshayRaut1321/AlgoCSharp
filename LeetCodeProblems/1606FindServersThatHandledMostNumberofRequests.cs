using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoCSharp.LeetCodeProblems
{
    internal class _1606FindServersThatHandledMostNumberofRequests
    {
        public IList<int> BusiestServers(int k, int[] arrival, int[] load)
        {
            var serverTracker = new Dictionary<int, Tuple<int, int, int>>();
            var serverVisitCounter = 0;
            for (int i = 0; i < arrival.Length;)
            {
                var currentServer = (i + serverVisitCounter) % k;
                if (!serverTracker.ContainsKey(currentServer))
                {
                    serverTracker.Add(currentServer, new Tuple<int, int, int>(1, arrival[i], load[i]));
                    i++;
                    serverVisitCounter = 0;
                }
                else
                {
                    var timeElapsed = serverTracker[currentServer].Item3 - arrival[i] - serverTracker[currentServer].Item2 + 1;
                    if (timeElapsed > 0)
                    {
                        if (serverVisitCounter + 1 < k)
                            serverVisitCounter++;
                        else
                        {
                            i++;
                            serverVisitCounter = 0;
                        }
                    }
                    else
                    {
                        serverTracker[currentServer] = new Tuple<int, int, int>(serverTracker[currentServer].Item1 + 1, arrival[i], load[i]);
                        i++;
                        serverVisitCounter = 0;
                    }
                }
            }
            var maxRequestsServer = new List<int>();
            for (int i = 0; i < serverTracker.Count; i++)
            {
                var server = serverTracker.ElementAt(i);
                if (server.Value.Item1 > 1)
                {
                    maxRequestsServer.Add(i);
                }
            }
            return maxRequestsServer;
        }
    }
}
