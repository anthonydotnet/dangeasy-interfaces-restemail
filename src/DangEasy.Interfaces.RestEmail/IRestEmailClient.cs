using System.Collections.Generic;
using System.Threading.Tasks;

namespace DangEasy.Interfaces.RestEmail
{
    public interface IRestEmailClient
    {
        Task<IRestResponse> SendAsync(string sender, string recipents, string subject, string htmlBody, string textBody = "", List<string> ccs = null, List<string> bccs = null, List<IFileAttachment> attachments = null);
        Task<IRestResponse> SendAsync(IRestRequest request);
    }
}