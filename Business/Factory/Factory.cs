using Business.Contracts;
using Business.Services;

namespace Business.Factory
{
    public class Factory : IFactory
    {
        #region Singleton
        private static Factory _instance;

        private static readonly object locker = new();
        public static Factory GetInstance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Factory();
                    }
                }
            }
            return _instance;
        }
        private Factory()
        {
            PeopleService = new PeopleService();
        }
        #endregion
        public IPeopleService PeopleService { get; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
