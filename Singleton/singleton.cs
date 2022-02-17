using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class singleton
    {
        private static singleton instance = null;

        public string colors = "";

        protected singleton() {
            colors = "Negro";
        }

        public  static singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new singleton();

                return instance;
            }
        }
        
    }
}
