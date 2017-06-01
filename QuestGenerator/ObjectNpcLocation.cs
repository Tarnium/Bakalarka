using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    /// <summary>
    /// This class is used to generate Object, Location and NPC names
    /// </summary>
    public static class ObjectNpcLocation
    {
        public static Random random = new Random();
        public static int locations = 0;
        public static int person = 0;
        public static int objects = 0;
        static Random r = new Random();
        static string vysl;

        public static string GenerateObjectNpcLocation()
        {
            switch (r.Next(3))
            {
                case 0:
                    GenerateLocation();
                    break;
                case 1:
                    GeneratePerson();            
                    break;
                case 2:
                    GenerateObject();
                    break;
            }
            return vysl;
        }

        public static string GenerateObjectNpc()
        {
            switch (r.Next(2))
            {
                case 0:
                    GeneratePerson();
                    break;
                case 1:
                    GenerateObject();
                    break;
            }
            return vysl;            
        }

        public static string GenerateObject()
        {
            vysl = "";
            vysl += "ObjectName" + objects++;
            return vysl;
        }

        public static string GeneratePerson()
        {
            vysl = "";
            vysl += "PersonName" + person++;
            return vysl;
        }

        public static string GenerateLocation()
        {
            vysl = "";
            vysl += "LocationName" + locations++;
            return vysl;
        }

        public static string GenerateNpcLocation()
        {
            switch (r.Next(2))
            {
                case 0:
                    GeneratePerson();
                    break;
                case 1:
                    GenerateLocation();
                    break;
            }
            return vysl;
        }

        public static string GenerateObjectLocation()
        {
            switch (r.Next(2))
            {
                case 0:
                    GenerateObject();
                    break;
                case 1:
                    GenerateLocation();
                    break;
            }
            return vysl;
        }
    }
}
