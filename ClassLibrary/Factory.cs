using ClassLibrary.Interfaces;


namespace ClassLibrary
{
    public class Factory
    {

        private static Factory _instance;

        public static Factory Instance => _instance ?? (_instance = new Factory());

        private IRepository _repository;

        public IRepository GetRepository() => _repository ?? (_repository = new Repository());
    }
}
