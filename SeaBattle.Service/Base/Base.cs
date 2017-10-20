using SeaBattle.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Service 
{
    public class Base
    {

        protected readonly SeaBattleContext _context;

        public Base(SeaBattleContext context)
        {
            _context = context;
        }
    }
}
