using System;
using System.Collections.Generic;
using System.Text;
using SageOfAstra.Services.Models;

namespace SageOfAstra.Services.Results
{
    public class BlacklistViolationResult
    {
        public bool IsViolating { get; set; }

        public ChannelBlacklist Blacklist { get; set; }
    }
}
