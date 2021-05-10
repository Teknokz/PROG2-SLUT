using System;

namespace Slutprojekt
{
    public class Lawyers : Court
    {
        public int Knowledge = 0;
        
            public void addKnowledge(int amount)
        {
            Knowledge += amount;

            
        }
    }

}
