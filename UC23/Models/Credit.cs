using CsvHelper.Configuration.Attributes;
using System.Runtime.Serialization;

namespace UC23.Models
{
    /// <summary>
    /// Credit related to Totle
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Numeric credits identifier.
        /// </summary>
        [Name("id")]
        public int Id { get; set; }

        /// <summary>
        /// Corresponding title id.
        /// </summary>
        [Name("title_id")]
        public int TitleId { get; set; }

        /// <summary>
        /// Full credits member name.
        /// </summary>
        [Name("real_name")]
        public string? RealName { get; set; }

        /// <summary>
        /// Corresponding movie (series) character name.
        /// </summary>
        [Name("character_name")]
        public string? CharacterName { get; set; }

        /// <summary>
        /// Corresponding role and be one of these: Director, Producer, Screenwriter, Actor, Actress, Cinematographer, Film Editor, Production Designer, Costume Designer, Music Composer.
        /// </summary>
        [Name("role")]
        public string? Role { get; set; }
    }
}
