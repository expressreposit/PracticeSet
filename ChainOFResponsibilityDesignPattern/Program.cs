using ChainOFResponsibilityDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Candidate candidate = new Candidate
        {
            Qualification = "MCA",
            ExpertiseDomain = "Expert",
            TechnolgyKnown = "dotner core",
            SalaryExpectation = 30000
        };
        InterviewClass hc = new InterviewClass();
        //hc.RegisterInterviews(new ScreeninRound(candidate));
        //hc.RegisterInterviews(new TechnicalRound(candidate));
        //hc.RegisterInterviews(new ManagerialRound(candidate));
        //hc.RegisterInterviews(new HRRound(candidate));

        hc.ProceedWithInterview();
    }
}