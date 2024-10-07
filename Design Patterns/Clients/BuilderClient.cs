using Design_Patterns.Creational.Builder;
using Design_Patterns.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Patterns.Helpers.GenericHelpers;

namespace Design_Patterns.Clients
{
    public class BuilderClient
    {
        static IAutoBuilder GetAutoBuilder(int selection) => selection == 0 ? new JettaBuilder() : new RougeBuilder();
        public static void BuildAuto()
        { 
    
            var exist = false;
            while (exist == false)
            {
                int userSelection = Convert.ToInt32(Console.ReadLine());

                var director = new AutoCreator(GetAutoBuilder(userSelection));

                director.CreateAuto();

                GetAllProperites(director.GetAuto());

            }

        }
    }
}
