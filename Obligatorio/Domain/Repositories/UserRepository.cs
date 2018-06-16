using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interface;
using Domain.Repositories;
using Domain.Logic;

namespace Domain.Repositories
{
    public class UserRepository: IUserRepository
    {
        private IUserHandler<Architect> architectHandler;
        private IUserHandler<Client> clientHandler;
        private IUserHandler<Designer> designerHandler;
        public UserRepository()
        {
            this.architectHandler = new ArchitectHandler();
            this.clientHandler = new ClientHandler();
            this.designerHandler = new DesignerHandler();
        }
        public void UserExists(String username, String password)
        {
            this.architectHandler.Ex(username, password);
            this.clientHandler.LookForUser(username, password);
            this.designerHandler.LookForUser(username, password);
        }
        public User GetUser(String username)
        {



            User userToFind = new User();
            if (this.architectHandler.IsArchitect(username))
            {
                userToFind = this.architectHandler.GetArchitectByUsername(username);
            }

            if (this.clientHandler.IsClient(username))
            {
                userToFind = this.clientHandler.GetClientByUsername(username);
            }

            if (this.designerHandler.IsDesigner(username))
            {
                userToFind = this.designerHandler.GetDesignerByUsername(username);
            }
            
            return userToFind;
        }
    }
}
