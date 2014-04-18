using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoCoolStuff
{
    public class GoogleAPI : IDisposable
    {


        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if(disposing)
                GC.SuppressFinalize(this);

        }

        ~GoogleAPI()
        {
            Dispose(false);
        }
    }
}
