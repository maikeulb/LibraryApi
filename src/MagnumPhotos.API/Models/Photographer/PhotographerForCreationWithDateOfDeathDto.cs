using System;

namespace MagnumPhotos.API.Models
{
    public class PhotographerForCreationWithDateOfDeathDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public DateTimeOffset? DateOfDeath { get; set; }
        public string Genre { get; set; }
    }
}
