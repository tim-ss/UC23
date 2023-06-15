using CsvHelper.Configuration.Attributes;

namespace UC23.Models
{
    /// <summary>
    /// Title model.
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Title identifier.
        /// </summary>
        [Name("id")]
        public int Id { get; set; }

        /// <summary>
        /// Movie (series) name.
        /// </summary>
        [Name("title")]
        public string TitleName { get; set; }

        /// <summary>
        /// Title description.
        /// </summary>
        [Name("description")]
        public string Description { get; set; }

        /// <summary>
        /// Common Era year format.
        /// </summary>
        [Name("release_year")]
        public int ReleaseYear { get; set; }

        /// <summary>
        /// One of these: G, PG, PG-13, R, NC-17, U, U/A, A, S, AL, 6, 9, 12, 12A, 15, 18, 18R, R18, R21, M, MA15+, R16, R18+, X18, T, E, E10+, EC, C, CA, GP, M/PG, TV-Y, TV-Y7, TV-G, TV-PG, TV-14, TV-MA.
        /// </summary>
        [Name("age_certification")]
        public string AgeCertification { get; set; }

        /// <summary>
        /// Common title duration in minutes.
        /// </summary>
        [Name("runtime")]
        public int Runtime { get; set; }

        /// <summary>
        /// List of strings representing various movie (series).
        /// </summary>
        [Name("genres")]
        public string Genres { get; set; }

        /// <summary>
        /// Country in ISO 3166-1 Alpha-3 code.
        /// </summary>
        [Name("production_country")]
        public string ProductionCountry { get; set; }

        /// <summary>
        /// The number of seasons for series or be empty for movies.
        /// </summary>
        [Name("seasons")]
        public int Seasons { get; set; }
    }
}
