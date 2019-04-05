namespace DangEasy.Interfaces.RestEmail
{
    public interface IFileAttachment
    {
        string Filename { get; set; }
        byte[] Bytes { get; set; }
        string AttachmentType { get; set; }
    }
}
