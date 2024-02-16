namespace ProjectFile.Models
{
    public static class Invite
    {
        public static List<GuestInvite> response = new List<GuestInvite>();    

        public static IEnumerable<GuestInvite> Response { get { return response; } }    

        public static void AddResponse(GuestInvite responses)
        {
            Console.WriteLine(Response);
            response.Add(responses);
        }
    }
}
