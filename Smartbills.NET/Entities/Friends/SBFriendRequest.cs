namespace Smartbills.NET.Entities.Friends
{
    public record SBFriendRequest : SBEntity
    {
        public string Avatar { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public long From { get; set; }
    }
}