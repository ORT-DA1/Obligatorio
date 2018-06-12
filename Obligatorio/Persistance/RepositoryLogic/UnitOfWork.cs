using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.RepositoryLogic
{
    public class UnitOfWork: IDisposable
    {
        private ClientRepository clientRepository;
        private DesignerRepository designerRepository;
        private UnitOfWork unit;
        private ContextDB context;
        private bool disposed;


        public UnitOfWork GetInstance()
        {
            if (this.unit == null)
            {
                return new UnitOfWork();
;            }

            return this;
        }

        private UnitOfWork()
        {
            context = new ContextDB();
        }

        public ClientRepository ClientRepository
        {
            get
            {
                if (clientRepository == null)
                {
                    clientRepository = new ClientRepository(context);
                }
                return clientRepository;
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

    }
}
