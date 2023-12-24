using TrainTicketManagement.Application.Common.Interfaces;

namespace TrainTicketManagement.Infrastructure.FileStore;

public class DirectoryWrapper : IDirectoryWrapper
{
    public void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }
}