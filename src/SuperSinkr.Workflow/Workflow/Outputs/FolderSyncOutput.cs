﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSinkr.Workflow.Mediator;

namespace SuperSinkr.Workflow.Workflow.Outputs
{
    public class FolderSyncOutputConfig
    {
        public string Folder { get; set; }
    }

    public class FolderSyncOutput : ISyncOutput
    {
        private FolderSyncOutputConfig _config;

        public FolderSyncOutput(FolderSyncOutputConfig config)
        {
            _config = config;
        }

        public void Output(SyncSession session)
        {
            foreach (var file in session.Files)
            {
                File.WriteAllBytes(Path.Combine(_config.Folder, file.Filename));
            }
        }
    }
}
