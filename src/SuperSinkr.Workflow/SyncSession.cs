﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSinkr.Workflow
{
    public class SyncSession
    {
        public Guid Id { get; set; }
        public List<SyncFile> Files { get; set; }
    }
}
