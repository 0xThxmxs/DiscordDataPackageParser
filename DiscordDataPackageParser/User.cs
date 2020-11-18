using System.Diagnostics.Eventing.Reader;

namespace DiscordDataPackageParser
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public int Discriminator { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
        public string Avatar_hash { get; set; }
        public bool Has_mobile { get; set; }
        public bool Needs_email_verification { get; set; }
        public string Premium_until { get; set; } //
        public long Flags { get; set; }
        public string Phone { get; set; } //
        public string Temp_banned_until { get; set; } //
        public string Ip { get; set; }
    }
}
