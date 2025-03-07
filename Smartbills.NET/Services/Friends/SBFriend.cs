using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Friends
{
    public record SBFriend : SBEntity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Avatar { get; set; }
        public long FriendId { get; set; }
    }
}
