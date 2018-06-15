using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Yut
    {
        #region singleton
        private static Yut _instance;
        
        public static Yut Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Yut();
                
                return _instance;
            }
        }
        
        private Yut()
        {
        }
        #endregion
        
        private Random _random = new Random();
        
        /// <summary>
        /// 윷을 던진다.
        /// </summary>
        /// <returns>1(도) ~ 5(모), -1(백도)</returns>
        public int Roll()
        {
            int number = _random.Next(6);

            if (number == 0)
                number = -1;

            return number;
        }
    }
}
