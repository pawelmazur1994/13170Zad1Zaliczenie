using System.ComponentModel.DataAnnotations;

namespace _13170Zad1Zaliczenie.Models
{
    public class PlytyMeblowe
    {
        [Range(1, 2100)]
        public int Szerokosc { get; set; }
        [Range(1, 2800)]
        public int Wysokosc { get; set; }

        public decimal Cena { get; set; }

        public int Ilosc { get; set; }

        public decimal Powierzchnia { get; set; }

        public decimal Suma { get; set; }
    }
}
