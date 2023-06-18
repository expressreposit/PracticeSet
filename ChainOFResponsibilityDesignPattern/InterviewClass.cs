using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsibilityDesignPattern
{
    public class InterviewClass
    {
        IInterviewHandler _rootHandler = null;
        IInterviewHandler _currentRound = null;
        public void RegisterInterviews(IInterviewHandler handler)
        {
            if(_rootHandler==null)
            {
                _rootHandler = handler;
                _currentRound = handler;
            }
            else
            {
                _currentRound._next = handler;
                _currentRound = _currentRound._next;
            }
        }

        public void ProceedWithInterview()
        {
            Execute(_rootHandler);
        }
        public void Execute(IInterviewHandler handler)
        {
            handler.ExecuteBefore();
            if(handler._candidate.InterviewedQualified && handler._next !=null)
            {
                Execute(handler._next);
            }
            handler.ExecuteAfter();
        }
    }
}
