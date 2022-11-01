// import * as css from "./styled";
import css from "./styled.module.css"
import logo from '../../utilites/img/delivery-logo.png';
import { useNavigate } from "react-router-dom";
import CarrinhoModal from "../CarrinhoModal";
import { useState } from "react";
import { NavDropdown, Dropdown } from "react-bootstrap";

const NavBarTop = () => {
    const [ openModalCarrinho,  setOpenModalCarrinho] = useState(false);
    const navigate = useNavigate();

    const ItensDropDownCategorias = ["Active", "AAAAA", "Rafael"];
    const ItensDropDownPerfil = ["Active", "AAAAA", "Rafael"];

    return(
        <>
            <CarrinhoModal openModalProps={openModalCarrinho}/>
            <div className={css.container_nav_bar}>
                <nav className={css.content_nav_bar}>

                    <div className={css.container_logo}>
                        <img onClick={() => navigate("/home")} src={logo} alt="logo-site" />
                    </div>

                    <div className={css.container_menu}>
                        <NavDropdown
                            id="nav-dropdown-dark-example"
                            title="Dropdown"
                            >
                            {ItensDropDownCategorias.map((item) => (
                                <NavDropdown.Item onClick={() => navigate(`/delivery/descobrir/${item}`)}>{item}</NavDropdown.Item>
                            ))}
                        </NavDropdown>
                        <div>
                            <span>Categorias</span>
                        </div>
                    </div>

                    <div className={css.container_input}>
                        <img src="https://img.icons8.com/ios-filled/30/000000/search--v1.png"/>
                        <input type="text" placeholder="Procure uma loja"/>
                    </div>

                    <div className={css.container_icons}>
                        <div>
                            <Dropdown>
                                <Dropdown.Toggle id={css.dropdown_custom} className={css.Dropdown}>
                                    <img src="https://img.icons8.com/small/40/000000/user-male-circle.png"/>
                                </Dropdown.Toggle>
                                <Dropdown.Menu>
                                    {ItensDropDownPerfil.map((item) => (
                                        <Dropdown.Item >{item}</Dropdown.Item>
                                    ))}
                                </Dropdown.Menu>
                            </Dropdown>
                        </div>
                        <div className={css.container_carrinho} onClick={() => setOpenModalCarrinho(!openModalCarrinho)}>
                            <img src="https://img.icons8.com/small/40/000000/shopping-cart.png"/>
                            <div>
                                <span>R$ 00,00</span>
                                <span>Itens: 0</span>
                            </div>
                        </div>
                    </div>
                </nav>
            </div>
        </>
    )
}

export default NavBarTop;