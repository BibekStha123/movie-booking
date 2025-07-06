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
        //cast ids
        public static readonly Guid Cast_ChrisHemsworth = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid Cast_TomHiddleston = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
        public static readonly Guid Cast_NataliePortman = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");
        public static readonly Guid Cast_RobertDowneyJr = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd");
        public static readonly Guid Cast_ScarlettJohansson = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
        //state ids
        public static readonly Guid State_SA = Guid.Parse("11111111-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid State_VIC = Guid.Parse("22222222-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
        public static readonly Guid State_NSW = Guid.Parse("33333333-cccc-cccc-cccc-cccccccccccc");
        public static readonly Guid State_WA = Guid.Parse("44444444-dddd-dddd-dddd-dddddddddddd");
        public static readonly Guid State_QLD = Guid.Parse("55555555-eeee-eeee-eeee-eeeeeeeeeeee");
        //cinema ids
        public static readonly Guid Cinema_EventAdelaide = Guid.Parse("aaaaaaaa-1111-1111-1111-111111111111");
        public static readonly Guid Cinema_HoytsMelbourne = Guid.Parse("aaaaaaaa-2222-2222-2222-222222222222");
        public static readonly Guid Cinema_LunaPerth = Guid.Parse("aaaaaaaa-3333-3333-3333-333333333333");
        //theatre ids
        public static readonly Guid Theatre_EventTheatre1 = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111");
        public static readonly Guid Theatre_HoytsTheatre1 = Guid.Parse("bbbbbbbb-2222-2222-2222-222222222222");
        public static readonly Guid Theatre_LunaTheatre1 = Guid.Parse("bbbbbbbb-3333-3333-3333-333333333333");
        //seat ids
        public static readonly Guid Seat_Event_Theatre1_SeatA1 = Guid.Parse("cccccccc-1111-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid Seat_Event_Theatre1_SeatA2 = Guid.Parse("cccccccc-1111-bbbb-bbbb-bbbbbbbbbbbb");

        public static readonly Guid Seat_Hoyts_Theatre1_SeatA1 = Guid.Parse("cccccccc-2222-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid Seat_Hoyts_Theatre1_SeatA2 = Guid.Parse("cccccccc-2222-bbbb-bbbb-bbbbbbbbbbbb");

        public static readonly Guid Seat_Luna_Theatre1_SeatA1 = Guid.Parse("cccccccc-3333-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid Seat_Luna_Theatre1_SeatA2 = Guid.Parse("cccccccc-3333-bbbb-bbbb-bbbbbbbbbbbb");

    }
}
