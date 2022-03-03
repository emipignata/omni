using System;
namespace Omnicanal.Models
{
    public class Admin : Usuario
    {
        public override Rol Rol => Rol.Admin;
    }
}