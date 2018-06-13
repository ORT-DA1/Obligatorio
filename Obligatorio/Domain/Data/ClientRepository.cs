using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Domain.Data
{
    public class ClientRepository
    {
        public void AddClient(Client client)
        {
            using (DatabaseContext ctx = new Domain.DatabaseContext())
            {
                ctx.Clients.Add(client);
                ctx.SaveChanges();
            }
        }
    }
}
