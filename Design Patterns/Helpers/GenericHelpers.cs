using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Helpers
{
    public static class GenericHelpers
    {
        public static void GetAllProperites(dynamic obj)
        {
            if (obj != null)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(obj)!;
                    Console.WriteLine("{0}={1}", name, value);
                };
            }

        }
    }
}
