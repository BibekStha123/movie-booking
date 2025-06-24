using MovieBooking.Application.DTO.Director;
using MovieBooking.Domain.Aggregates.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking.Application.Mapper
{
    internal static class DirectorMapper
    {
        public static DirectorResponse ToDirectorDTO(this Director model)
        {
            return new DirectorResponse
            {
                Id = model.Id,
                Name = model.Name,
            };
        }
    }
}
