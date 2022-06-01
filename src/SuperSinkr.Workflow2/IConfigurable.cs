namespace SuperSinkr.Workflow2
{
    public interface IConfigurable<in TConfiguration>
    {
        void Configure(TConfiguration config);
    }
}
