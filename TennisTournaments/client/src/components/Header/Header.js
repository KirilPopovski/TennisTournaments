import style from "./Header.module.css"
import NavItem from "./NavItem/NavItem";

const Header = () => {
    return (
        <nav className={style.navigation} align="center">
        <ul>
          <NavItem />
        </ul>
      </nav>
    );
};

export default Header;