import style from "./NavItem.module.css"

const NavItem = () => {
    return (
        <>
            <li className={style.listItem}><a href="sth">Tournaments</a></li>
            <li className={style.listItem}><a href="sth">Players</a></li>
            <li className={style.listItem}><a href="sth">Add tournament</a></li>
            <li className={style.listItem}><a href="sth">Add player</a></li>
        </>
    );
};

export default NavItem;