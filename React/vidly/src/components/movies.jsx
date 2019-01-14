import React, { Component } from "react";
import { getMovies } from "../services/fakeMovieService.js";
import { getGenres } from "../services/fakeGenreService.js";
import Like from "./common/like";
import Pagination from "./common/pagination";
import { paginate } from "../utils/paginate";
import ListGroup from "./listGroup";

export class Movies extends Component {
  state = {
    movies: [],
    genres: [],
    currentGenre: "",
    currentPage: 1,
    pageSize: 4
  };

  componentDidMount() {
    this.setState({ movies: getMovies(), genres: getGenres() })
  }

  handleDelete = movie => {
    const movies = this.state.movies.filter(m => m._id !== movie._id);
    this.setState({ movies: movies });
  };

  handlePageChange = page => {
    this.setState({ currentPage: page });
  };

  handleGenreSelect = genre => {
    let movies = getMovies();
    this.state.currentGenre = genre;
    if (genre !== undefined) {
      movies = movies.filter(x => x.genre._id === genre._id);
    }
    this.setState({ movies: movies });
  };

  handleLike = movie => {
    const movies = [...this.state.movies];
    const index = movies.indexOf(movie);
    movies[index].liked = !movie.liked;
    this.setState({ movies });
  };

  render() {
    const { length: count } = this.state.movies;
    const {
      pageSize,
      currentPage,  
      movies: allMovies,
      genres: allGenres
    } = this.state;

    if (count === 0) return "There are no movies in the database.";

    const movies = paginate(allMovies, currentPage, pageSize);

    return (
      <div className="row">
        <div className="col-3">
          <ListGroup items={this.state.genres} 
            textProperty="name"
            valueProperty="_id"
            onItemSelect={this.handleGenreSelect} />
        </div>
        <div className="col">
          <p>Showing {count} movies in the database.</p>
          <table className="table">
            <thead>
              <tr>
                <th scope="col">Title</th>
                <th scope="col">Genre</th>
                <th scope="col">Stock</th>
                <th scope="col">Rate</th>
                <th scope="col" />
                <th scope="col" />
              </tr>
            </thead>
            <tbody>
              {movies.map(movie => (
                <tr key={movie._id}>
                  <td>{movie.title}</td>
                  <td>{movie.genre.name}</td>
                  <td>{movie.numberInStock}</td>
                  <td>{movie.dailyRentalRate}</td>
                  <td>
                    <Like
                      liked={movie.liked}
                      onClick={() => this.handleLike(movie)}
                    />
                  </td>
                  <td>
                    <button
                      className="btn btn-danger btn-sm"
                      onClick={() => this.handleDelete(movie)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
          <Pagination
            itemsCount={count}
            pageSize={pageSize}
            currentPage={currentPage}
            onPageChange={this.handlePageChange}
          />
        </div>
      </div>
    );
  }
}

export default Movies;
