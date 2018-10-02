using System;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class PowerSet
    {
        public List<List<int>> GetSubsets(List<int> set)
        {
            return GetSubsets(set, 0);
        }

        public List<List<int>> GetSubsets(List<int> set, int index)
        {
            List<List<int>> allSubsets;
            if(set.Count == index) {
                allSubsets = new List<List<int>>();
                allSubsets.Add(new List<int>());
            }else{
                allSubsets = GetSubsets(set, index + 1);
                int item = set[index];
                List<List<int>> moreSubsets = new List<List<int>>();
                foreach (List<int> subset in allSubsets)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(item);
                    moreSubsets.Add(newSubset);
                }
                allSubsets.AddRange(moreSubsets);
            }

            return allSubsets;

        }
    }
}