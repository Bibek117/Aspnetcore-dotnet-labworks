import {NavLink} from 'react-router-dom'
import React from "react";

const Navbar = () => {
  return (
    <>
      <nav className="navbar__container">
        <ul className="navbar__links">
          <li>
            <NavLink
              to="/"
              className={({ isActive }) => 
                 isActive ? "active" : ""}
            >
              Home
            </NavLink>
          </li>
          <li>
            <NavLink
              className={({isActive}) =>  isActive ? "active" : ""
              }
              to="/calculator"
            >
              Calculator
            </NavLink>
          </li>
        </ul>
      </nav>
    </>
  );
}
export default Navbar