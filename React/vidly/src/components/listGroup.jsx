import React, { Component } from "react";
const ListGroup = props => {
  const { items, textProperty, valueProperty, onFilter, onClear } = props;
  return (
    <ul className="list-group">
      <a href="#" className="list-group-item list-group-item-action active" onClick={() => onFilter()}>All Genres</a>
      {items.map(item => (
        <li
          key={item[valueProperty]}
          className="list-group-item list-group-item-action"
          onClick={() => onFilter(item)}
        >
          {item[textProperty]}
        </li>
      ))}
    </ul>
  );
};

export default ListGroup;
