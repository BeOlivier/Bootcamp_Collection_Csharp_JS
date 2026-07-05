namespace Patterns.Business.SaltBusiness
{
    public class Customer
    {
        private int _id;
        private string _city;
        private int _shoeSize;

        public Customer(string city, int shoeSize, int id)
        {
            _id = id;
            _city = city;
            _shoeSize = shoeSize;
        }

        public int GetShoeSize() => _shoeSize;
        public string GetCity() => _city;
        public int GetId() => _id;
        
        public void UpdateShoeSize(int size) => _shoeSize = size;
        public void UpdateCity(string city) => _city = city;
        // public void GetId() => _id;
        

        
    }
}