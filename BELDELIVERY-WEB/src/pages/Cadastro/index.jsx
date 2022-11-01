import { useNavigate } from "react-router-dom";
import css from "./styled.module.css";
import { Button } from "react-bootstrap";
import { useEffect, useState } from "react";

const Cadastro = () => {
    const [ typeCadastro, setTypeCadastro ] = useState();

    const [ clientName, setClientName ] = useState("");
    const [ clientEmail, setClientEmail ] = useState("");
    const [ clientPassword, setClientPassword ] = useState("");
    const [ clientConfirmPassword, setClientConfirmPassword ] = useState("");

    const [ storeName, setStoreName ] = useState("");
    const [ storetEmail, setStoreEmail ] = useState("");
    const [ storePassword, setStorePassword ] = useState("");
    const [ storeConfirmPassword, setStoreConfirmPassword ] = useState("");

    const navigate = useNavigate();

    const typeCadastroOption = [
        "Client",
        "Store"
    ];

    const post = () => {
    };

    const validateName = () => {
    };

    const validateEmail = () => {
    };

    const validatePassword = () => {
    };

    return(
        <>
           {!typeCadastro ? (
                <section className={css.container_login}>
                    <div className={css.container_select_type}>
                        <h1>Faça seu cadastro</h1>
                        <p>Escolha o tipo da sua conta:</p>
                        <div>
                            <button onClick={e => setTypeCadastro("Client")}>Cliente</button>
                            <button onClick={e => setTypeCadastro("Store")}>Loja</button>
                        </div>
                    </div>
                </section>
           ) : (
            <section className={css.container_login}>
                <div className={css.card_login}>
                    <h1>Faça seu cadastro</h1>
                    {typeCadastro === "Client" && (
                        <div className={css.container_form}>
                            <label for="name">Nome:</label>
                            <input 
                                type="text"
                                id="name"
                                onChange={e => setClientName(e.target.value)}
                                value={clientName}
                            />

                            <label for="email">Email:</label>
                            <input 
                                type="email"
                                id="password"
                            />
                            
                            <label for="password">Senha:</label>
                            <input
                                type="password"
                                id="confirm-password"
                            />

                            <label for="confirm-password">Confirme a senha:</label>
                            <input 
                                type="password"
                                id="confirm-password"
                            />
                        </div>
                    )}

                    {typeCadastro === "Store" && (
                        <div className={css.container_form}>
                            <label for="name">Nome:</label>
                            <input 
                                type="text"
                                id="name"
                                onChange={e => setStoreName(e.target.value)}
                                value={storeName}
                            />

                            <label for="email">Email:</label>
                            <input 
                                type="text"
                                id="password"
                            />
                            
                            <label for="password">Senha:</label>
                            <input
                                type="password"
                                id="confirm-password"
                            />

                            <label for="confirm-password">Confirme a senha:</label>
                            <input 
                                type="password"
                                id="confirm-password"
                            />
                        </div>
                    )}
                    <div>
                        <Button onClick={() => post()} variant="primary">Cadastrar</Button>
                    </div>
                </div>
            </section>
        )}
        </>
    )
}

export default Cadastro;