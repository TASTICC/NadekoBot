﻿using System;

namespace NadekoBot.Services.Database.Models
{
    public class DiscordUser : DbEntity
    {
        public ulong UserId { get; set; }
        public string Username { get; set; }
        public string Discriminator { get; set; }
        public string AvatarId { get; set; }
        
        public ClubInfo Club { get; set; }
        public DateTime LastLevelUp { get; set; } = DateTime.UtcNow;
        public DateTime LastXpGain { get; set; } = DateTime.MinValue;
        public XpNotificationType NotifyOnLevelUp { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DiscordUser du
                ? du.UserId == UserId
                : false;
        }

        public override int GetHashCode()
        {
            return UserId.GetHashCode();
        }

        public override string ToString() => 
            Username + "#" + Discriminator;
    }
}
