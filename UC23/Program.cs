using Bogus;
using UC23;
using UC23.Models;

Randomizer.Seed = new Random(8675309);

var ageCertificationsString = "G, PG, PG-13, R, NC-17, U, U/A, A, S, AL, 6, 9, 12, 12A, 15, 18, 18R, R18, R21, M, MA15+, R16, R18+, X18, T, E, E10+, EC, C, CA, GP, M/PG, TV-Y, TV-Y7, TV-G, TV-PG, TV-14, TV-MA";
var ageCertifications = ageCertificationsString.Split(',');

var rolesString = "Director, Producer, Screenwriter, Actor, Actress, Cinematographer, Film Editor, Production Designer, Costume Designer, Music Composer";
var roles = rolesString.Split(',');

var genresString = "Action, Adventure, Comedy, Drama, Fantasy, Horror, Mystery, Romance, Sci-Fi, Thriller, Animation, Documentary, Crime, Family, Historical, Musical, War, Western";
var genres = genresString.Split(',');

var titleId = 0;
var titleRules = new Faker<Title>()
    .StrictMode(true)
    .RuleFor(o => o.Id, f => titleId++)
    .RuleFor(o => o.TitleName, f => f.Lorem.Sentence(5))
    .RuleFor(o => o.Description, f => f.Lorem.Sentence(10))
    .RuleFor(o => o.ReleaseYear, f => f.Date.Past(50).Year)
    .RuleFor(o => o.AgeCertification, f => f.PickRandom(ageCertifications))
    .RuleFor(o => o.Runtime, f => f.Random.Int(20, 240))
    .RuleFor(o => o.ProductionCountry, f => f.Address.CountryCode())
    .RuleFor(o => o.Seasons, f => f.Random.Int(1, 10))
    .RuleFor(o => o.Genres, f => f.PickRandom(genres))
    .RuleFor(o => o.Runtime, f => f.Random.Int(20, 240));

var titles = titleRules.GenerateBetween(100, 200);

var titlesIds = titles.Select(t => t.Id);

var creditId = 0;
var creditRules = new Faker<Credit>()
    .StrictMode(true)
    .RuleFor(o => o.Id, f => creditId++)
    .RuleFor(o => o.TitleId, f => f.PickRandom(titlesIds))
    .RuleFor(o => o.RealName, f => f.Name.FullName())
    .RuleFor(o => o.CharacterName, f => f.Name.FullName())
    .RuleFor(o => o.Role, f => f.PickRandom(roles));

var credits = creditRules.GenerateBetween(100, 200);

CsvExport.WriteData(credits, "credits.csv");
CsvExport.WriteData(titles, "titles.csv");