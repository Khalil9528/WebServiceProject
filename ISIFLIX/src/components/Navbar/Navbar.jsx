import { ArrowDropDown, Notifications, Search } from "@material-ui/icons";
import { useState } from "react";
import "./navbar.scss";

const Navbar = () => {
  const [isScrolled, setIsScrolled] = useState(false);

  window.onscroll = () => {
    setIsScrolled(window.pageYOffset === 0 ? false : true);
    return () => (window.onscroll = null);
  };

  const fetchMovies = async () => {
    try {
      const response = await fetch("http://localhost:5175/api/movie"); // Assurez-vous que l'URL est correcte
      const data = await response.json();
      console.log(data); // Affiche les données des films dans la console pour vérification
    } catch (error) {
      console.error("Erreur lors de la récupération des films :", error);
    }
  };

  return (
    <div className={isScrolled ? "navbar scrolled" : "navbar"}>
      <div className="container">
        <div className="left">
          <img
            src="../../ISIFLIX.png"
            alt=""
          />
          <span>Homepage</span>
          <span>Series</span>
          <span onClick={fetchMovies}>Movies</span> {/* Déclenche l'appel API */}
          <span>New and Popular</span>
          <span>My List</span>
        </div>
        <div className="right">
          <Search className="icon" />
          <span>KID</span>
          <Notifications className="icon" />
          <img
            src="../../khalil.png"
            alt=""
          />
          <div className="profile">
            <ArrowDropDown className="icon" />
            <div className="options">
              <span>Settings</span>
              <span>Logout</span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Navbar;
