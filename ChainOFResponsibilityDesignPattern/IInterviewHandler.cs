using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsibilityDesignPattern
{
    public interface IInterviewHandler
    {
        IInterviewHandler _next { get; set; }
        Candidate _candidate { get; set; }
        void ExecuteBefore();
        void ExecuteAfter();
    }
}
