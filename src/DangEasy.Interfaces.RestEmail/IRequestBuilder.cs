using System.Collections.Generic;

namespace DangEasy.Interfaces.RestEmail
{
    public interface IRequestBuilder
    {
        IRestRequest BuildRequest(string sender, string recipent, string subject, string htmlBody, string textBody);
        IRestRequest BuildRequest(string sender, List<string> recipents, string subject, string htmlBody, string textBody = "", List<string> ccs = null, List<string> bccs = null, List<IFileAttachment> attachments = null);
    }
}