using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsibilityDesignPattern
{
    public class Candidate
    {
        public string Qualification { get; set; }//B.E, B.Tech, MTech, ME, MCA ..etc
        public string TechnolgyKnown { get; set; }//c#, .net core, .net
        public string ExpertiseDomain { get; set; }//Beginner, Moderate, Expert
        public int SalaryExpectation { get; set; }//Epected Salary
        public bool InterviewedQualified = true;
    }
}
