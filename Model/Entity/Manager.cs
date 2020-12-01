using System;
using System.Collections.Generic;

namespace Model.Entity
{
    public class Manager
    {
        public static double CalculateAvgRating(IEnumerable<Pupil> list)
        {
            double avg = 0;
            var count = 0;

            var iterator = list.GetEnumerator();

            while (iterator.MoveNext())
            {
                avg += iterator.Current.Rating;
                count++;
            }

            return Math.Round(avg / count, 1);
        }
    }
}