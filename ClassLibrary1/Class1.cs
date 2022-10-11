using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        static void S_Main(string[] args)
        {
            Test me = new Test();
            Console.WriteLine(me.ret());
        }
    }

    public class Test
    {
        public System.Reflection.MemberInfo element;
        private Type _attributetype;

        public bool result = true;

        public bool ret()
        {
            result = JsonPropertyAttribute.IsDefined(element, _attributetype);
            try
            {
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
        }


    }
}
