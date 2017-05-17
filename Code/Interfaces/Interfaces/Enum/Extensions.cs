using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
   public static partial class Extensions
    {

        public static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }

        public static T RandomEnumValue<T>(int randomSeed)
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random(randomSeed).Next(v.Length));
        }
        public static T RandomEnumValue<T>(Random random)
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }


    }
}
