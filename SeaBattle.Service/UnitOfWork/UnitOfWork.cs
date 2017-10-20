using SeaBattle.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Service 
{
    public class UnitOfWork
    {
        private static UnitOfWork _instance;

        private UnitOfWork()
        {
            _seaBattleContext = new SeaBattleContext();
        }

        private SeaBattleContext _seaBattleContext;
        private UserService _userService;
        private UserAccountService _userAccountService;
        private BattlefieldService _battlefielldService;

        public static UnitOfWork Instance => _instance ?? (_instance = new UnitOfWork());

        public UserService UserService => _userService ?? (_userService = new UserService(_seaBattleContext));
        public UserAccountService UserAccauntService => _userAccountService ?? (_userAccountService = new UserAccountService(_seaBattleContext));
        public BattlefieldService BattlefieldService => _battlefielldService ?? (_battlefielldService = new BattlefieldService(_seaBattleContext));
        

    }
}
