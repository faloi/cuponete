using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.DTOs;

namespace GrouponDesktop.ManagementUsuario
{
    sealed class UsuarioHome
    {
        private static UsuarioHome instance;
        public Usuario usuario { get; set; }

        private UsuarioHome()
        {
            this.usuario = new Usuario();
        }

        public static UsuarioHome Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsuarioHome();
                }
                return instance;
            }
        }
    }
}