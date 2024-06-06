using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSteamBackendPry.entities
{
    public class Game : BaseEntity
    {
        private int userCode;

        private string gender;
        private string name;
        private double price;

        public Game(int code, int userCode, string gender, string name, double price) : base(code) {
            this.userCode = userCode;
            this.gender = gender;
            this.name = name;
            this.price = price; 
        }

        public int UserCode { get => userCode; }
        public string Gender { get => gender; }
        public string Name { get => name; }
        public double Price { get => price;}

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"juego.nombre={name}");
            sb.AppendLine($"juego.genero={gender}");
            sb.AppendLine($"juego.precio={price}");
            sb.AppendLine($"juego.usuario-codigo={userCode}");
            return sb.ToString();   
        }
    }
}
