using System;
using System.Collections.Generic;
using System.Text;

namespace BearAdapter
{
    class BearAdapter : IDog
    {
        private IBear bear; // Class variable to store a bear instance

        public void Bark()
        {
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            bear.TryEat("salmon");
        }

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }
    }
}
