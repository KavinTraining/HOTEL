using System.ComponentModel.DataAnnotations.Schema;

namespace HOTEL.Data
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }

        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }

        public Country Country { get; set; }

    }
}
