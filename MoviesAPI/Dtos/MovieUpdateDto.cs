namespace MoviesAPI.Dtos
{
    public class MovieUpdateDto : MovieDto
    {
        public IFormFile? Poster { get; set; }

    }
}
