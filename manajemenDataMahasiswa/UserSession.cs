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
        public static string Nip { get; private set; }
        public static string Nim { get; private set; }

        public static void StartSession(string nama, string email, string nip, string nim)
        {
            Nama = nama;
            Email = email;
            Nip = nip;
            Nim = nim;
        }

        public static void EndSession()
        {
            Nama = null;
            Email = null;
            Nip = null;
            Nim = null;
        }
    }
}
