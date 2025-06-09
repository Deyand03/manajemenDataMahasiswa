using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manajemenDataMahasiswa
{
    public static class UserSession
    {
        public static string Nama { get; private set; }
        public static string Email { get; private set; }
        public static string Role { get; private set; }

        public static void StartSession(string nama, string email, string role)
        {
            Nama = nama;
            Email = email;
            Role = role;
        }

        public static void EndSession()
        {
            Nama = null;
            Email = null;
            Role = null;
        }
    }
}
