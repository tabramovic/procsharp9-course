namespace Dotnetos.Conference.WebApi.Entities
{
    public record OnlineSpeaker : Speaker
    {
        public bool OnlineSetupTested { get; init; }

        public OnlineSpeaker(string firstName, string lastName, string company, bool setupTested) : base(firstName, lastName, company)
        {
            OnlineSetupTested = setupTested;
        }
    }
}