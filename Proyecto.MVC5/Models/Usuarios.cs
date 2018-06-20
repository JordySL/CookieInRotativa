

using System.Collections.Generic;

namespace Proyecto.MVC5.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Usuarios> UserList = new List<Usuarios>();
        public List<Usuarios> ReturnList()
        {
            UserList.Add(new Usuarios()
            { ID = 1, UserName = "Jordy", Password = "1234" });
            UserList.Add(new Usuarios()
            { ID = 2, UserName = "Luis", Password = "12345" });
            return UserList;
        }
    }
}