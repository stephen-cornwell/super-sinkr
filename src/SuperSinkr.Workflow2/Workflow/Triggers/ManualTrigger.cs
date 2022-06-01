namespace SuperSinkr.Workflow2.Workflow.Triggers
{
    public event EventHandler WorkflowTriggered;

    public interface ITrigger
    {
        void Trigger();
        void OnTrigger();
    }

    public class ManualTrigger : ITrigger
    {
    }
}
