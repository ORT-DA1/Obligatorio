using System;

namespace Persistance.RepositoryLogic
{
    public class UnitOfWork: IDisposable
    {
        private ClientRepository clientRepository;
        private DesignerRepository designerRepository;
        private UnitOfWork unit;
        private ContextDB _context;
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
            _context = new ContextDB();
        }

        public ClientRepository ClientRepository
        {
            get
            {
                if (clientRepository == null)
                {
                    clientRepository = new ClientRepository(_context);
                }

                return clientRepository;
            }
        }

        public DesignerRepository DesignerRepository
        {
            get
            {
                if (designerRepository == null)
                {
                    designerRepository = new DesignerRepository(_context);
                }

                return designerRepository;
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
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

    }
}
