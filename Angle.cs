using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1.properties
{
   public class angle
    {
        public int degree;
        public float minute;
        public char direction;
        public angle(int deg, float min, char direct)
        {
            degree = deg;
            minute = min;
            direction = direct;
        }
        public void setangle(int deg, float min, char direct)
        {

            degree = deg;
            minute = min;
            direction = direct;
        }
        public override string ToString()
        {
            return $"{degree}\u00b0{minute}'{direction}";
        }
        public static angle FromString(string str)
        {
            string[] differ = str.Split('°', '\'', '\"', ' ');
            int degre = int.Parse(differ[0]);
            float min = float.Parse(differ[1]);
            char direct = differ[2][0];
            return new angle(degre, min, direct);

        }
    }
}
