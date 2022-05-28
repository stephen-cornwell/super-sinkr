using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSinkr.Workflow
{
    public interface IConfigurable<in TConfiguration>
    {
        void Configure(TConfiguration config);
    }
}
