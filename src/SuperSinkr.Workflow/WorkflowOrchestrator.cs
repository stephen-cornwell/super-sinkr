using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservablePipelines;

namespace SuperSinkr.Workflow
{
    internal class WorkflowOrchestrator
    {
        private IPipelineBuilder pipelineBuilder;
        public WorkflowOrchestrator()
        {
            var pipeline = pipelineBuilder
    //.ConfigureOptions(builder => builder
    //    .Add(new MessageFilterPipeOptions(Guid.Empty))
    //)
    .ConfigurePipeline(builder => builder
        .AddSource(Input)
        .AddStep<Input, SyncSession>()
       // .AddStep<MessageFilterPipe, ChatMessage>()
       // .AddStep<MessageTransformPipe, IdentifiedChatMessage>()
       // .AddStep(new ConsoleLoggerPipe())
    )
    .Build();
            pipeline.sub
        }
    }
}
