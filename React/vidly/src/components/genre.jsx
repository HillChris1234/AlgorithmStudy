import React, { Component } from "react";
const Genre = props => {
  const { genres, onFilter } = props;
  return (
    <div className="list-group">
      {genres.map(genre => (
        <a
          href="#"
          className="list-group-item list-group-item-action"
          key={genre._id}
          onClick={() => onFilter(genre)}
        >
          {genre.name}
        </a>
      ))}
    </div>
  );
};

export default Genre;
