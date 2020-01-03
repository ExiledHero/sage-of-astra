using System;
using System.ComponentModel.DataAnnotations;

namespace SageOfAstra.Data
{
    public class NicknameAlias
    {
        [Key]
        public int Key { get; set; }

        public ulong UserId { get; set; }

        public ulong GuildId { get; set; }

        public DateTime Until { get; set; }

        public string Alias { get; set; }
    }
}
