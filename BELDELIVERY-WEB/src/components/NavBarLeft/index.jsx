import { useState } from "react";
import { useNavigate } from "react-router-dom";
import css from "./styled.module.css";

const NavBarLeft = () => {
    const [openBar, setOpenBar] = useState(true);

    const navigate = useNavigate();
    
    return (
        <>
            <img className={css.icon_open_menu} onClick={() => setOpenBar(!openBar)} src="https://img.icons8.com/ios-filled/50/000000/menu--v1.png"/> 
            {openBar ? (
                <div className={css.container_left_bar}>
                <div className={css.nav_container}>
                    <div>
                        <div className={css.container_avatar}>
                            <div className={css.container_img_avatar}>

                            </div>
                            <span>Rafael Alves</span>
                        </div>
                        <div onClick={() => navigate("/perfil")}>
                            <img src="https://img.icons8.com/small/40/000000/user-male-circle.png"/>
                            <span>Perfil</span>
                        </div>
                        <div onClick={() => navigate("/perfil/pedidos")}>
                            <img src="https://img.icons8.com/sf-ultralight/40/null/mobile-order.png"/>
                            <span>Pedidos</span>
                        </div>
                        <div onClick={() => navigate("/perfil/enderecos")}>
                            <img src="https://img.icons8.com/ios/40/null/order-delivered.png"/>
                            <span>Endereços</span>
                        </div>
                        <div onClick={() => navigate("/perfil/alterar-senha")}>
                            <img src="https://img.icons8.com/ios/35/null/private-lock.png"/>
                            <span>Alterar senha</span>
                        </div>
                    </div>
                    <div>
                        <div onClick={() => navigate("/home")}>
                            <img src="https://img.icons8.com/windows/40/null/exit.png"/>
                            <span>Sair</span>
                        </div>
                    </div>
                </div>
            </div>
            ) :
                <div className={css.hidde_bar}>
                    <div className={css.nav_container_hidde}>
                        <div>
                            <div onClick={() => navigate("/perfil")}>
                                <img src="https://img.icons8.com/small/40/000000/user-male-circle.png"/>
                            </div>
                            <div onClick={() => navigate("/perfil/pedidos")}>
                                <img src="https://img.icons8.com/sf-ultralight/40/null/mobile-order.png"/>
                            </div>
                            <div onClick={() => navigate("/perfil/enderecos")}>
                                <img src="https://img.icons8.com/ios/40/null/order-delivered.png"/>
                            </div>
                            <div onClick={() => navigate("/perfil/alterar-senha")}>
                                <img src="https://img.icons8.com/ios/35/null/private-lock.png"/>
                            </div>
                        </div>
                        <div>
                            <div>
                                <img src="https://img.icons8.com/windows/40/null/exit.png"/>
                            </div>
                        </div>
                    </div>
                </div>
            }
        </>
       
    )
}

export default NavBarLeft;