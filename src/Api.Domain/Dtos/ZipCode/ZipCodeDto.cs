using System;
using Api.Domain.Dtos.City;

namespace Api.Domain.Dtos.ZipCode
{
    public class ZipCodeDto
    {
        public Guid Id { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public Guid CityId { get; set; }
        public CityDtoComplete City { get; set; }
    }
}