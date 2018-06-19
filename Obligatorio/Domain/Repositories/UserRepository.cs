using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interface;
using Domain.Repositories;
using Domain.Logic;
using Domain.Exceptions;

namespace Domain.Repositories
{
    public class UserRepository: IUserRepository
    {
        private IUserHandler<Architect> architectHandler;
        private IUserHandler<Client> clientHandler;
        private IUserHandler<Designer> designerHandler;
        private AdminHandler adminHandler;
        public UserRepository()
        {
            this.architectHandler = new ArchitectHandler();
            this.clientHandler = new ClientHandler();
            this.designerHandler = new DesignerHandler();
            this.adminHandler = new AdminHandler();
        }
      
        public User GetUser(String username, String password)
        {
            User userToFind = null;

            if (userToFind == null)
            {
                userToFind = this.adminHandler.GetByUsernameAndPassword(username, password);
            }
            if (userToFind == null)
            {
                userToFind = this.architectHandler.GetByUsernameAndPassword(username, password);
            }
            if (userToFind == null)
            {
                userToFind = this.clientHandler.GetByUsernameAndPassword(username, password);
            }
            if (userToFind == null)
            {
                userToFind = this.designerHandler.GetByUsernameAndPassword(username, password);
            }

            if (userToFind == null)
            {
                throw new ExceptionController(ExceptionMessage.USER_INVALID_LOGIN);
            }

            return userToFind;
        }

        public void UserExist(String username)
        {
            User userToFind = null;


            if (userToFind == null)
            {
                userToFind = this.adminHandler.GetByUsername(username);
            }
            if (userToFind == null)
            {
                userToFind = this.architectHandler.GetByUsername(username);
            }
            if (userToFind == null)
            {
                userToFind = this.clientHandler.GetByUsername(username);
            }
            if (userToFind == null)
            {
                userToFind = this.designerHandler.GetByUsername(username);
            }

            if (userToFind != null)
            {
                throw new ExceptionController(ExceptionMessage.USER_ALREADY_EXSIST);
            }
        } 
    }
}
