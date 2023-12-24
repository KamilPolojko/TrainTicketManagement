using TrainTicketManagement.Application.Common.Interfaces;

namespace TrainTicketManagement.Infrastructure.FileStore;

public class FileWrapper : IFileWrapper
{
    public void WriteAllBytes(string outputFile, byte[] content)
    {
        File.WriteAllBytes(outputFile,content);
    }
}