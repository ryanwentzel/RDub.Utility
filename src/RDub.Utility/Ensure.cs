using System;

namespace RDub.Utility
{
    public static class Ensure
    {
         public static void ArgumentNotNull(object argument, string name)
         {
             if (argument != null) return;

             throw new ArgumentNullException(name);
         }
    }
}