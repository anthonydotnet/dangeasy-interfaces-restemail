namespace DangEasy.Interfaces.RestEmail
{
    public interface IRestRequest
    {
        void AddParameter(string name, object value);
        void AddFile(string name, byte[] bytes, string fileName);
    }
}
