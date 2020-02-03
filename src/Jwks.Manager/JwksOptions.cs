using System;

namespace Jwks.Manager
{
    public class JwksOptions
    {
        public Algorithm Algorithm { get; set; } = Algorithm.ES256;
        public int DaysUntilExpire { get; set; } = 90;
        public string KeyPrefix { get; set; } = $"{Environment.MachineName}_";
    }
}