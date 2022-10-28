using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class UsuarioFakeDB
    {
        private static List<Usuario> usuarios;

        public static List<Usuario> Usuarios
        {
            get
            {
                if (usuarios == null)
                {
                    usuarios = new List<Usuario>();
                    Carregar();
                }
                return usuarios;
            }
        }

        private static void Carregar()
        {
            usuarios.Add(new Usuario(1, "login1", "senha1", "permissao1"));
            usuarios.Add(new Usuario(2, "login2", "senha2", "permissao2"));
            usuarios.Add(new Usuario(3, "login3", "senha3", "permissao3"));
            usuarios.Add(new Usuario(4, "login4", "senha4", "permissao4"));
            usuarios.Add(new Usuario(5, "login5", "senha5", "permissao5"));
        }
    }
}

