using NoSteamBackendPry.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSteamBackendPry.repository
{
    internal abstract class BaseRepo
    {
        protected ConnectionDb connDb;

        protected BaseRepo() {
            connDb = new ConnectionDb(ConnectionDb.UTN_CONN_STRING);
        }
    }
}
