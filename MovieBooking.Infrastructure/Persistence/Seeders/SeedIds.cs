using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking.Infrastructure.Persistence.Seeders
{
    internal static class SeedIds
    {
        //director ids
        public static readonly Guid Director_Nolan = Guid.Parse("11111111-1111-1111-1111-111111111111");
        public static readonly Guid Director_Spielberg = Guid.Parse("22222222-2222-2222-2222-222222222222");
        //movie ids
        public static readonly Guid Movie_Inception = Guid.Parse("33333333-3333-3333-3333-333333333333");
        public static readonly Guid Movie_Jaws = Guid.Parse("44444444-4444-4444-4444-444444444444");
        //genre ids
        public static readonly Guid Genre_Drama = Guid.Parse("11111111-1111-1111-1111-111111111111");
        public static readonly Guid Genre_Action = Guid.Parse("22222222-2222-2222-2222-222222222222");
        public static readonly Guid Genre_Horror = Guid.Parse("33333333-3333-3333-3333-333333333333");
        public static readonly Guid Genre_LoveStory = Guid.Parse("44444444-4444-4444-4444-444444444444");
        public static readonly Guid Genre_SciFi = Guid.Parse("55555555-5555-5555-5555-555555555555");
        public static readonly Guid Genre_Thriller = Guid.Parse("66666666-6666-6666-6666-666666666666");
    }
}
