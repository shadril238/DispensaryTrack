//shadril238
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Repo
    {
        internal DispensaryContext db;
        internal Repo()
        {
            db = new DispensaryContext();
        }
    }
}
