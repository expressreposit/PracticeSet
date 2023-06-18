using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsibilityDesignPattern
{
    public class HandlerClasses
    {
    }
    public class ScreeninRound
    {
        public Candidate _candidate;
        public IInterviewHandler _next { get; set; }
        public ScreeninRound(Candidate candidate)
        {
            _candidate= candidate;
        }
        public void ExecuteBefore()
        {
            if(_candidate.Qualification == "MCA")
            {
                _candidate.InterviewedQualified = true;
                Console.WriteLine("Screening Round Qualified");
            }
            else
            {
                _candidate.InterviewedQualified = false;
                Console.WriteLine("Screening Round not Qualified");
            }
        }
        public void ExecuteAfter()
        {
            if(_candidate.InterviewedQualified) 
            {
                Console.WriteLine("Submitting Screening Round Feedback Document");
            }
        }
    }
    public class TechnicalRound
    {
        public Candidate _candidate { get; set; }
        public TechnicalRound(Candidate candidate)
        {
            _candidate = candidate; 
        }
        public void ExecuteBefore() 
        {
            if(_candidate.TechnolgyKnown =="dotnet core")
            {
                _candidate.InterviewedQualified = true;
                Console.WriteLine("Technical Round Qualified");
            }
            else
            {
                _candidate.InterviewedQualified = false;
                Console.WriteLine("Technical Round not Qualified");
            }
        }
        public void ExecuteAfter()
        {
            if (_candidate.InterviewedQualified)
            {
                Console.WriteLine("Submitting Technical Round Feedback Documents");
            }
        }
    }
    public class ManagerialRound
    {
        public Candidate _candidate { get; set; }
        public ManagerialRound(Candidate candidate)
        {
            _candidate = candidate;
        }
        public void ExecuteBefore()
        {
            if (_candidate.ExpertiseDomain == "Expert")
            {
                _candidate.InterviewedQualified = true;
                Console.WriteLine("Managerial Round Qualified");
            }
            else
            {
                _candidate.InterviewedQualified = false;
                Console.WriteLine("Managerial Round not Qualified");
            }
        }
        public void ExecuteAfter()
        {
            if (_candidate.InterviewedQualified)
            {
                Console.WriteLine("Submitting Managerial Round Feedback Documents");
            }
        }
    }
    public class HRRound
    {
        public IInterviewHandler _next { get; set; }
        public Candidate _candidate { get; set; }
        public HRRound(Candidate candidate)
        {
            _candidate = candidate;
        }
        public void ExecuteBefore()
        {
            if (_candidate.SalaryExpectation <= 300000)
            {
                _candidate.InterviewedQualified = true;
                Console.WriteLine("HR Round Qualified");
            }
            else
            {
                _candidate.InterviewedQualified = false;
                Console.WriteLine("HR Round not Qualified");
            }
        }
        public void ExecuteAfter()
        {
            if (_candidate.InterviewedQualified)
            {
                Console.WriteLine("Submitting HR Round Feedback Documents");
            }
        }
    }
}
