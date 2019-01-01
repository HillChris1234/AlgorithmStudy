import React, { Component } from "react";
import { getMovies } from "../services/fakeMovieService.js";
import Like from "./common/like";
import Pagination from "./common/pagination";

export class Movies extends Component {
  state = {
    movies: getMovies(),
    pageSize: 4
  };

  handleDelete = movie => {
    const movies = this.state.movies.filter(m => m._id !== movie._id);
    this.setState({ movies: movies });
  };

  handlePageChange = page => {
    console.log(page);
  };

  handleLike = movie => {
    const movies = [...this.state.movies];
    const index = movies.indexOf(movie);
    movies[index].liked = !movie.liked;
    this.setState({ movies });
    console.log(movie);
  };

  render() {
    const moviesCount = this.state.movies.length;
    if (moviesCount === 0) return "There are no movies in the database.";

    return (
      <div>
        <p>Showing {moviesCount} movies in the database.</p>
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
            {this.state.movies.map(movie => (
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
          itemsCount={moviesCount}
          pageSize={this.state.pageSize}
          onPageChange={this.handlePageChange}
        />
      </div>
    );
  }
}

export default Movies;
