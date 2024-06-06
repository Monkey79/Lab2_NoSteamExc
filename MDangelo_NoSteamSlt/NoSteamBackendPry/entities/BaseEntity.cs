using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSteamBackendPry.entities
{
    public abstract class BaseEntity
    {
        private int code; //AI

        public BaseEntity(int code) {
            this.code = code;
        }

        public int Code { get => code;}

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"BaseEntity.codigo={code}");
            return sb.ToString();
        }
    }
}
