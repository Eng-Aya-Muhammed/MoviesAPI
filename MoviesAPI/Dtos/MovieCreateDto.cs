namespace MoviesAPI.Dtos
{
    public class MovieCreateDto : MovieDto
    {
        public IFormFile Poster { get; set; }

    }
}
