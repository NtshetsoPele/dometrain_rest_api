using MovieList = System.Collections.Generic.IEnumerable<Movies.Contracts.Responses.MoviesResponse>;

namespace Movies.Contracts.Responses;

public class MoviesResponse
{
    //public required IEnumerable<MoviesResponse> Items { get; init; } = Enumerable.Empty<MoviesResponse>();
    public required MovieList Items { get; init; } = Enumerable.Empty<MoviesResponse>();
}
