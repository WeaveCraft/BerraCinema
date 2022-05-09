using Berra.DataAccess.Repository;
using Berra.Dataccess.Data;
using Berra.Models;
using Berra.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

            }

            if (!_roleManager.RoleExistsAsync(SD.AdminRole).GetAwaiter().GetResult())
            {
                //Skapa roller för inloggning
                _roleManager.CreateAsync(new IdentityRole(SD.AdminRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.ManagerRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.FrontDeskRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.CustomerRole)).GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "admin@live.com",
                    Email = "admin@live.com",
                    PhoneNumber = "070-123 45 67",
                    EmailConfirmed = true,
                    FirstName = "Admin",
                    LastName = "Nimda"
                }, "Admin123!").GetAwaiter().GetResult();

                ApplicationUser user = _db.ApplicationUser.FirstOrDefault(u => u.Email == "admin@live.com");

                _userManager.AddToRoleAsync(user, SD.ManagerRole).GetAwaiter().GetResult();
            }

            var categoryId = new List<Category>()
            {
                new Category()
                {
                    Name = "Horror",
                    DisplayOrder = 1
                },
                new Category()
                {
                    Name = "Drama",
                    DisplayOrder = 1
                },
                new Category()
                {
                    Name = "Cartoon",
                    DisplayOrder = 1
                },
                new Category()
                {
                    Name = "Fiction",
                    DisplayOrder = 1
                },
                new Category()
                {
                    Name = "Action",
                    DisplayOrder = 2
                },
                new Category()
                {
                    Name = "Comedy",
                    DisplayOrder = 2
                },
                new Category()
                {
                    Name = "Documentary",
                    DisplayOrder = 2
                },
                new Category()
                {
                    Name = "Parody",
                    DisplayOrder = 2
                }

            };

            var movieDuration = new List<MovieDuration>()
            {
                new MovieDuration()
                {
                    Name = "1h 35min",
                    Date = DateTime.Now.AddDays(1),
                },
                new MovieDuration()
                {
                    Name = "1h 35min",
                    Date = DateTime.Now.AddDays(-1),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(0),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(2),
                },
                new MovieDuration()
                {
                    Name = "2h 55min",
                    Date = DateTime.Now.AddDays(3),
                },
                new MovieDuration()
                {
                    Name = "2h 55min",
                    Date = DateTime.Now.AddDays(4),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(5),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(6),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(7),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(8),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(9),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(10),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(11),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(12),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(13),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(14),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(15),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(16),
                },
                new MovieDuration()
                {
                    Name = "2h 25min",
                    Date = DateTime.Now.AddDays(17),
                }
            };
            
            var movies = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "The Help",
                    Description = "Societsflickan Skeeter återvänder från college till sin hemstad i den amerikanska södern fast besluten att bli författare. Hon vänder upp och ner på den lilla staden när hon börjar intervjua svarta kvinnor som arbetar som hemhjälp åt rika vita.",
                    Image = "/images/menuItems/help.jpg",
                    Price = 99,
                    MovieDurationId = 1,
                    CategoryId = 1,
                    Seats = 8
                },
                new MenuItem()
                {
                    Name = "Sunset Boulevard",
                    Description = "Sunset Boulevard är en amerikansk noir-film från 1950 med element av drama och svart humor. Filmen regisserades och var delvis skriven av Billy Wilder. Den fick sitt namn efter esplanaden med samma namn, vid vilken stumfilmens stjärnor byggde hus och levde, och som går genom Los Angeles och Beverly Hills",
                    Image = "/images/menuItems/1950.jpg",
                    Price = 45,
                    MovieDurationId = 2,
                    CategoryId = 2,
                    Seats = 37
                },
                new MenuItem()
                {
                    Name = "Aladdin",
                    Description = "Sultanens vackra dotter, prinsessan Jasmine, har allt man kan tänka sig. Utom frihet. En natt rymmer hon från palatset och träffar den fattige men godhjärtade pojken Aladdin. Innan de vet ordet av är de förälskade i varandra.",
                    Image = "/images/menuItems/aladdin-poster.jpg",
                    Price = 95,
                    MovieDurationId = 3,
                    CategoryId = 1,
                    Seats = 0
                },
                new MenuItem()
                {
                    Name = "Avengers",
                    Description = "Efter de katastrofala händelserna, som startades av Thanos, och vilka raderade halva universum och splittrade The Avengers tvingas de återstående medlemmarna i Avengers ta upp en sista kamp.",
                    Image = "/images/menuItems/avengers.jpg",
                    Price = 45,
                    MovieDurationId = 4,
                    CategoryId = 6,
                    Seats = 11
                },
                new MenuItem()
                {
                    Name = "Alien",
                    Description = "Ett skepp skickas för att undersöka en SOS-signal och råkar ut för en rymdvarelse som börjar döda besättningen en efter en.",
                    Image = "/images/menuItems/aliens.jpg",
                    Price = 125,
                    MovieDurationId = 5,
                    CategoryId = 2,
                    Seats = 3
                },
                new MenuItem()
                {
                    Name = "Notting Hill",
                    Description = "William Thacker äger en liten bokhandel som för en slumrande tillvaro. En dag kliver den berömda filmstjärnan Anna Scott in i hans affär - och hans liv. Efter det blir ingenting sig likt vare sig för henne eller William.",
                    Image = "/images/menuItems/e.jpg",
                    Price = 145,
                    MovieDurationId = 7,
                    CategoryId = 2,
                    Seats = 49
                },
                new MenuItem()
                {
                    Name = "Mostly Camping",
                    Description = "Nu ska vi campa så det skriker om det, vi vill inte lämna denna skog förrän den förbannande kapitalismen som vi hatar är borta!",
                    Image = "/images/menuItems/f16.jpg",
                    Price = 19,
                    MovieDurationId = 6,
                    CategoryId = 8,
                    Seats = 50
                },
                new MenuItem()
                {
                    Name = "Gravity",
                    Description = "Efter en olycka lämnas de två astronauterna Ryan Stone och Matt Kowalsky helt ensamma ute i rymden - och endast ihopkopplade med varandra glider de ut i mörkret. Samtidigt som rädslan övergår i panik så försvinner lite syre för varje litet andetag.",
                    Image = "/images/menuItems/gravkity.jpg",
                    Price = 100,
                    MovieDurationId = 8,
                    CategoryId = 1,
                    Seats = 29
                },
                new MenuItem()
                {
                    Name = "Green Book",
                    Description = "Den före detta utkastaren Tony Lip anställs för att köra den världsberömda klassiska pianisten Don Shirley på en konsertturné genom djupaste amerikanska södern. Längs vägen måste det udda paret förlita sig på The Green Book för att hitta de restauranger och hotell som godkänner afroamerikanska gäster.",
                    Image = "/images/menuItems/green-book-web.jpg",
                    Price = 10,
                    MovieDurationId = 9,
                    CategoryId = 2,
                    Seats = 41
                },
                new MenuItem()
                {
                    Name = "Hangover",
                    Description = "De planerade en oförglömlig svensexa i Las Vegas. Men dagen efter den stora kvällen minns ingen vad som hände. Varför är det en baby i deras hotellsvit? Vem har tagit in en tiger i badrummet? Och framförallt: var är brudgummen Doug?",
                    Image = "/images/menuItems/hangover.jpg",
                    Price = 85,
                    MovieDurationId = 11,
                    CategoryId = 3,
                    Seats = 23
                },
                    new MenuItem()
                {
                    Name = "Joker",
                    Description = "Arthur, en man som möts av grymhet och förakt av samhället. Dagtid arbetar han som clown och på kvällarna försöker han slå igenom som stand-up komiker... men det känns som att skratten alltid är på hans bekostnad.",
                    Image = "/images/menuItems/images.jpg",
                    Price = 199,
                    MovieDurationId = 10,
                    CategoryId = 7,
                    Seats = 28
                },
                    new MenuItem()
                {
                    Name = "Internet Famous",
                    Description = "Fem internetkändisar reser tvärs över USA för att tävla om en egen tv-serie.",
                    Image = "/images/menuItems/internet-famous-movie-poster.jpg",
                    Price = 25,
                    MovieDurationId = 12,
                    CategoryId = 3,
                    Seats = 25
                },
                new MenuItem()
                {
                    Name = "Titanic",
                    Description = "RMS Titanic var en oceanångare byggd 1909–1911 för atlantrutten Southampton–New York. Fartyget ritades av några av dåtidens bästa ingenjörer och utrustades med den mest avancerade teknik som fanns tillgänglig.",
                    Image = "/images/menuItems/kQyjY.jpg",
                    Price = 85,
                    MovieDurationId = 13,
                    CategoryId = 4,
                    Seats = 44
                },
                new MenuItem()
                {
                    Name = "Matrix",
                    Description = "Datahackern Neo möter mystiska rebeller som berättar sanningen om världen han bor i - och om hans roll i kriget mot dem som kontrollerar det som till synes verkar vara verkligheten.",
                    Image = "/images/menuItems/matrix.jpg",
                    Price = 100,
                    MovieDurationId = 14,
                    CategoryId = 5,
                    Seats = 50
                },
                new MenuItem()
                {
                    Name = "Pirati dei Caraibi",
                    Description = "Pirati dei Caraibi (Pirates of the Caribbean) è un media franchise della Disney, incentrato su una serie cinematografica prodotta da Jerry Bruckheimer e basata sull'attrazione Pirates of the Caribbean dei parchi Walt Disney. La saga è composta da cinque film e si è espansa in fumetti, romanzi e altri media. La saga ha come protagonista il pirata Jack Sparrow, interpretato da Johnny Depp, e ha incassato complessivamente quattro miliardi e mezzo di dollari.",
                    Image = "/images/menuItems/pirates.jpg",
                    Price = 85,
                    MovieDurationId = 15,
                    CategoryId = 1,
                    Seats = 46
                },
                new MenuItem()
                {
                    Name = "Parasite",
                    Description = "Parasit är en sydkoreansk drama-komedifilm från 2019 regisserad av Bong Joon-ho som även skrivit manus tillsammans med Han Jin-won. Distributör i Sverige är TriArt Film. Filmen, med Sverigepremiär 20 december 2019, är en avancerad kombination av komedi, thriller, satir och skräck.",
                    Image = "/images/menuItems/parasite.webp",
                    Price = 99,
                    MovieDurationId = 16,
                    CategoryId = 8,
                    Seats = 22
                },
                new MenuItem()
                {
                    Name = "Pulp Fiction",
                    Description = "Torpederna Vincent och Jules utför ett uppdrag åt sin chef, samtidigt som boxaren Butch ställer upp i en fixad match, medan Pumpkin och Honey Bunny rånar en restaurang.",
                    Image = "/images/menuItems/pulp.jpg",
                    Price = 40,
                    MovieDurationId = 17,
                    CategoryId = 3,
                    Seats = 25
                },
                new MenuItem()
                {
                    Name = "Scooby-Doo",
                    Description = "Scooby-Doo, var är du! är den första serien av Hanna-Barberas Scooby-Doo. TV-serien skapades av Joe Ruby och Ken Spears, och hade premiär på CBS 13 september 1969 och fortsatte under två säsonger med totalt 25 avsnitt. Dess sista avsnitt hade premiär 31 oktober 1970.",
                    Image = "/images/menuItems/scooby.jpg",
                    Price = 105,
                    MovieDurationId = 18,
                    CategoryId = 5,
                    Seats = 41
                },
                new MenuItem()
                {
                    Name = "The Walking Dead",
                    Description = "Polisen Rick Grimes har legat i koma efter en olycka i arbetet. När han vaknar upp har världen förändrats. En zombieepidemi har brutit ut och de flesta människor är döda eller har förvandlats till zombies som ständigt letar efter levande kött.",
                    Image = "/images/menuItems/walkingdead.jpg",
                    Price = 105,
                    MovieDurationId = 19,
                    CategoryId = 4,
                    Seats = 41
                }
            };
            bool insert = _db.Category.Any();
            if (insert != true)
            {
                _db.AddRange(categoryId);
                _db.SaveChanges();
            }
            bool insert1 = _db.MovieDuration.Any();
            if (insert != true)
            {
                _db.AddRange(movieDuration);
                _db.SaveChanges();
            }
            bool insert2 = _db.MenuItem.Any();
            if (insert != true)
            {
                _db.AddRange(movies);
                _db.SaveChanges();
            }
            return;
        }
    }
}
