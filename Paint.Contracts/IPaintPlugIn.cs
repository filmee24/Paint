using Creek.Extensibility.Plugins;

namespace Paint.Contracts
{
    public interface IPaintPlugIn : IPlugIn
    {
        IFileType[] FileTypes { get; }
    }
}
