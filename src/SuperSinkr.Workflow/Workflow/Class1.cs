using MediatR;
using SuperSinkr.Workflow.Mediator;
using SuperSinkr.Workflow.Workflow.Processors;

namespace SuperSinkr.Workflow.Workflow
{
    // Input
    // Pipeline
    //  -> Processors
    // Output



    public abstract class JobNotification : INotification
    {
        public SyncSession Session { get; }

        protected JobNotification(SyncSession session)
        {
            Session = session;
        }
    }



    public class FilesRetrievedNotification : JobNotification
    {
        public FilesRetrievedNotification(SyncSession session) : base(session) { }
    }

    public class PipelineStartedNotification : JobNotification
    {
        public PipelineStartedNotification(SyncSession session) : base(session) { }
    }

    public class ProcessFileCommand : ICommand<FileProcessorResult>
    {
        public SyncFile File { get; }

        public ProcessFileCommand(SyncFile file)
        {
            File = file;
        }
    }


    public class SyncFile
    {
        public string Filename { get; }
        public string Path { get; }

        public byte[] File { get; }

        public SyncFile(string filename, string path, byte[] file)
        {
            Filename = filename;
            Path = path;
            File = file;
        }
    }

    //public class ProcessingHistory
    //{
    //    public byte[] File { get; }
    //    public string Processor { get; }

    //    public ProcessingHistory(byte[] file, string processor)
    //    {
    //        File = file;
    //        Processor = processor;
    //    }
    //}

    public class SyncWorkflowTest
    {
        public void Foo()
        {
            // on app start -
            // Load configured inputs (triggers for syncs).
            // Register pipeline
            // -> Register processors
            // Register output
            // -------- wait for sync trigger -----
            // on trigger
            //  execute input (gather files in directory structure)
            //      place gathered files in cached queue
            //      pass each file to pipeline
            //      cache processed files 
            //      on successful exceution of all pipeline steps
            //          execute output
            //      else
            //          show error
            // -------- wait for sync trigger -----

            //var workflow = new SyncWorkflow();
            // add input
            // add pipline and processors
            // add output
            // start input monitoring


        }
    }
}