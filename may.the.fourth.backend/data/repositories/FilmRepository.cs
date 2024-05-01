using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Contexts;
using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Domain.Model;

namespace May.The.Fourth.Backend.Data.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly StarWarsContext ctx;

        public FilmRepository(StarWarsContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Film>> GetFilmsAsync()       
        {
            try
            {
                ctx.Database.EnsureCreated();
                IQueryable<Film> films = await Task.FromResult(ctx.Films.Include(p => p.Characters).Select(film => new Film
                {                          
                    Id = film.Id,
                    Title = film.Title,
                    Episode = film.Episode,
                    OpeningCrawl = film.OpeningCrawl,
                    Director = film.Director,
                    Producer = film.Producer,
                    ReleaseDate = film.ReleaseDate,
                    Characters = film.Characters
                        .Select(c => new Character{ Id = c.Id, Name = c.Name })
                        .OrderBy(o => o.Id)
                        .ToList()
                }));
                return films.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }
               
        public async Task<Film?> GetFilmByIdAsync(int id)
        {
            try
            {
                var film = await ctx.Films
                    .Include(p => p.Characters)
                    .Where(w => w.Id == id)
                    .Select(s => new Film
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Episode = s.Episode,
                        OpeningCrawl = s.OpeningCrawl,
                        Director = s.Director,
                        Producer = s.Producer,
                        ReleaseDate = s.ReleaseDate,
                        Characters = s.Characters
                            .Select(c => new Character{ Id = c.Id, Name = c.Name })
                            .OrderBy(o => o.Id)
                            .ToList()
                    })
                    .FirstOrDefaultAsync();
                return film;
            }
            catch(Exception e)
            {
                throw new Exception($"An error has occurred. Contact your admins and give them this reference: {e.StackTrace}");
            }
        }
    }
}