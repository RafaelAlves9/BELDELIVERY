import { useEffect, useState } from "react";
import NavBarTop from "../../components/NavBarTop";
import css from "./styled.module.css";
import axios from "axios";
import { useNavigate } from "react-router-dom";

const PerfilCliente = () => {
    const [ user, setUser ] = useState();
    const [ actualOptionMenu, setActualOptionMenu ] = useState({
        geral: null,
        enderecos: null,
        pedidos: null,
    });

    const navigate = useNavigate();
    const actualUrl = [window.location.pathname];
    const id = localStorage.getItem("id");

    useEffect(() => {
        handleOptionMenuByRouter();
        axios.get(`https://localhost:7221/api/ClientProfile/get-by-idclient/${id}`)
        .then((res) => {
            setUser(res.data);
        })
        .catch((error) => console.log(error));
    }, []);

    const redirectRouterMenu = (option) => {
        switch (option){
            case "Geral":
                navigate("/perfil")
                break;
            case "Endereços":
                navigate("/perfil/enderecos")
                break;
            case "Pedidos":
                navigate("/perfil/pedidos")
                break;
        }
        console.log(actualOptionMenu)
    };

    const handleOptionMenuByRouter = () => {
        return(
            verifyEndercoUrl(), verifyGeneralUrl(), verifyPedidoUrl()
        )
    };

    const verifyGeneralUrl = () => {
        if (actualUrl[0] === ("/perfil")){
            setActualOptionMenu({
                ...actualOptionMenu,
                geral: true,
                enderecos: null,
                pedidos: null,
            });
            return actualOptionMenu;
        }
        return actualOptionMenu;
    };
    const verifyEndercoUrl = () => {
        if (actualUrl[0].includes("enderecos")){
            setActualOptionMenu({
                ...actualOptionMenu,
                geral: null,
                enderecos: true,
                pedidos: null,
            });
            return actualOptionMenu;
        }
        return actualOptionMenu;
    };
    const verifyPedidoUrl = () => {
        if (actualUrl[0].includes("pedidos")){
            setActualOptionMenu({
                ...actualOptionMenu,
                geral: null,
                enderecos: null,
                pedidos: true,
            });
            return actualOptionMenu;
        }
        return actualOptionMenu;
    };

    return(
        <>
            <NavBarTop />
            <div className={css.container}>
                <div className={css.tittle}>
                    <h2>Meu Perfil</h2>
                    <button>EDITAR</button>
                </div>
                <div className={css.switch_route_perfil}>
                    <div
                        className={actualOptionMenu.geral ? css.card_switch_active : css.card_switch}
                        onClick={() => redirectRouterMenu("Geral")}
                    >
                        <p>Geral</p>
                    </div>
                    <div 
                        className={actualOptionMenu.enderecos ? css.card_switch_active : css.card_switch}
                        onClick={() => redirectRouterMenu("Endereços")}
                    >
                        <p>Endereços</p>
                    </div>
                    <div 
                        className={actualOptionMenu.pedidos ? css.card_switch_active : css.card_switch}
                        onClick={() => redirectRouterMenu("Pedidos")}
                    >
                        <p>Pedidos</p>
                    </div>
                </div>
                <div className={css.container_form_user}>
                    <div>
                        <span>Nome:</span>
                        <span>{user?.name || "Nome não cadastrado"}</span>
                    </div>
                    <hr />
                    <div>
                        <span>CPF:</span>
                        <span>{user?.document || "Documento não cadastrado"}</span>
                    </div>
                    <hr />
                    <div>
                        <span>Telefone:</span>
                        <span>{user?.telPhone || "Telefone não cadastrado"}</span>
                    </div>
                    <hr />
                    <div>
                        <span>Celular:</span>
                        <span>{user?.cellPhone || "Celular não cadastrado"}</span>
                    </div>
                    <hr />
                    <div>
                        <span>Título:</span>
                        <span>{user?.tittleStatus || "0"}</span>
                    </div>
                    <hr />
                    <div>
                        <span>Pedidos:</span>
                        <span>{user?.orders || "0"}</span>
                    </div>
                </div>
            </div>
        </>
    )
}

export default PerfilCliente;