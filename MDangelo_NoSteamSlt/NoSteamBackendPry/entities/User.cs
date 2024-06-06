using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSteamBackendPry.entities
{
    public class User : BaseEntity
    {
        private string name;
        private List<Game> games;

        public User(int code, string name) :base(code){            
            this.name = name;
            games = new List<Game>();
        }

        public List<Game> Games { get => games; }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"usuario.nombre={name}");
            return sb.ToString();
        }
    }
}
