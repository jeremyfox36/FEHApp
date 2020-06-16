using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FEHServicesLib
{
    public class LMoments
    {
        public float Beta0(float[] amaxArray)
        {
            float b0 = amaxArray.Sum() / amaxArray.Length;
            float roundedB0 = (float)Math.Round(b0 * 100f)/100f;
            return roundedB0;
        }

        public float Beta1(float[] amaxArray)
        {
            Array.Sort(amaxArray);

            int n = amaxArray.Length;
            
            float b1_1 = 1f/(n * (n-1));

            float b1_2 = 0f;
            int i = 0;
            foreach (float amax in amaxArray)
            {
                float intermediate = i * amax;
                b1_2 += intermediate;
                i++;
            }

            double output = b1_1 * b1_2;
            //rounds to 2 decimal places
            return (float)Math.Round(output * 100f)/100f;
        }

        public float Beta2(float[] amaxArray)
        {
            Array.Sort(amaxArray);

            int n = amaxArray.Length;

            float b2_1 = 1f / (n * (n - 1) * (n - 2));

            float b2_2 = 0f;
            int i = 0;
            foreach(float amax in amaxArray)
            {
                float intermediate = i * (i-1) * amax;
                b2_2 += intermediate;
                i++;
            }

            double output = b2_1 * b2_2;
            return (float)Math.Round(output * 100f) / 100f;
        }

        public float Lambda1(float[] amaxArray)
        {
            return Beta0(amaxArray);
        }

        public float Lambda2(float[] amaxArray)
        {
            return 2 * Beta1(amaxArray) - Beta0(amaxArray); 
        }

        
    }
}
