using Omnicanal.Models.Enums;
using System;
namespace Omnicanal.Models
{
    public class Cliente : Usuario
    {
        public override Rol Rol => Rol.Cliente;
    }
}
}