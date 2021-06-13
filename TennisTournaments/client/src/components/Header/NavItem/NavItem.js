import style from "./NavItem.module.css"
import { NavLink } from 'react-router-dom';

const NavItem = () => {
    return (
        <>
            <NavLink exact={true} to="/tournaments"><li className={style.listItem}>Tournaments</li></NavLink>
            <NavLink exact={true} to="/players"><li className={style.listItem}>Players</li></NavLink>
        </>
    );
};

export default NavItem;