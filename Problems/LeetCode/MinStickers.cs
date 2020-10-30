using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class MinStickers
    {
        public static int Solve(string[] stickers, string target)
        {
            Dictionary<char, Dictionary<int, int>> d = new Dictionary<char, Dictionary<int, int>>();
            for (int i = 0; i < stickers.Length; i++)
            {
                foreach (var c in stickers[i])
                {
                    if (!d.ContainsKey(c))
                    {
                        d[c] = new Dictionary<int, int>();
                    }

                    if (!d[c].ContainsKey(i))
                    {
                        d[c][i] = 0;

                    }

                    d[c][i] = d[c][i] + 1;

                }
            }

            Dictionary<int, int> numberOfCharsWeCanGetFromEachSticker = new Dictionary<int, int>();
            var sorted = target.ToCharArray();
            Array.Sort(sorted);
            int start = 0;
            int end = -1;
            for (int i = 0; i < sorted.Length; i++)
            {
                if (d.ContainsKey(sorted[i]))
                {
                    if (i < sorted.Length - 1)
                    {
                        if (sorted[i] != sorted[i + 1])
                        {
                            end = i;
                        }
                    }
                    else
                    {
                        end = i;
                    }

                    if (end != -1)
                    {
                        foreach (var h in d[sorted[i]])
                        {
                            if (!numberOfCharsWeCanGetFromEachSticker.ContainsKey(h.Key))
                            {
                                numberOfCharsWeCanGetFromEachSticker[h.Key] = 0;
                            }

                            if ((end - start + 1) > h.Value)
                            {
                                numberOfCharsWeCanGetFromEachSticker[h.Key] = h.Value;
                            }
                            else
                            {
                                numberOfCharsWeCanGetFromEachSticker[h.Key] = end - start + 1;
                            }

                        }

                        start = i + 1;
                        end = -1;
                    }

                }
                else
                {
                    return -1;
                }
            }

            // how many times we use a sticker to get a character 
            Dictionary<char, Dictionary<int, int>> usedStickers = new Dictionary<char, Dictionary<int, int>>();
            foreach (var c in target)
            {
                // for every sticker  containing this character  we choose the sticker that we can grab from it the maximum number 
                // of characters 
                int max = -1;
                HashSet<int> ignoredStickers = new HashSet<int>();
                int hello = 12;
                if (usedStickers.ContainsKey(c))
                {
                    var usedStickersForThisChar = usedStickers[c].Keys;
                    foreach (var st in usedStickersForThisChar)
                    {
                        hello = st;
                        if (usedStickers[c][st] == d[c][st])
                        {

                            ignoredStickers.Add(st);
                        }
                    }
                }

                foreach (var v in d[c])
                {
                    if (ignoredStickers.Contains(v.Key))
                    {
                        continue;
                    }

                    if (max == -1)
                    {
                        max = v.Key;
                    }
                    else
                    {
                        if (numberOfCharsWeCanGetFromEachSticker[v.Key] > max)
                        {
                            max = v.Key;
                        }
                    }

                }

                if (max == -1)
                {
                    max = hello;

                }

                if (!usedStickers.ContainsKey(c))
                {
                    usedStickers[c] = new Dictionary<int, int>();

                }

                if (!usedStickers[c].ContainsKey(max))
                {
                    usedStickers[c][max] = 0;
                }

                usedStickers[c][max] = usedStickers[c][max] + 1;
                

            }

            Dictionary<int,int> k = new Dictionary<int, int>();
            foreach (var c in usedStickers)
            {
                foreach (var sticker in c.Value) 
                {
                    var mod = sticker.Value%d[c.Key][sticker.Key];
                    int used;
                    if (sticker.Value <= d[c.Key][sticker.Key])
                    {
                        used = 1;
                    }
                    else
                    {
                        used = (sticker.Value / d[c.Key][sticker.Key])+1;
                       
                    }
                    
                    if (!k.ContainsKey(sticker.Key))
                    {
                        k[sticker.Key] = used;
                    }
                    else
                    {
                        if (k[sticker.Key] < used)
                        {
                            k[sticker.Key] = used;
                        }
                    }
                }
            }

            int res = 0;
            foreach (var n in k)
            {
                res += n.Value;
            }
            return res;
        }
    }
}