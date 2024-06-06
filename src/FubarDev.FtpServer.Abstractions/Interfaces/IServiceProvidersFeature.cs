using System;

namespace FubarDev.FtpServer.Interfaces
{
    public interface IServiceProvidersFeature
    {
        IServiceProvider RequestServices { get; set; }
    }
}
