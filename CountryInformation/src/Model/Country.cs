namespace CountryInformation.Model
{
    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string[] AltSpellings { get; set; }
        public string Relevance { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public Translations Translations_ { get; set; }
        public int Population { get; set; }
        public float?[] Latlng { get; set; }
        public string Demonym { get; set; }
        public float? Area { get; set; }
        public float? Gini { get; set; }
        public string[] Timezones { get; set; }
        public string[] Borders { get; set; }
        public string NativeName { get; set; }
        public string[] CallingCodes { get; set; }
        public string[] TopLevelDomain { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string[] Currencies { get; set; }
        public string[] Languages { get; set; }
        public class Translations
        {
            public string DE { get; set; }
            public string ES { get; set; }
            public string FR { get; set; }
            public string JA { get; set; }
            public string IT { get; set; }
        }
    }
}
