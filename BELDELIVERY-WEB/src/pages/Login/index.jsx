import { useNavigate } from "react-router-dom";
import { Button } from "react-bootstrap";
import css from "./styled.module.css";

const Login = () => {
    const navigate = useNavigate();

    return(
        <>
           <section className={css.container_login}>
                <div className={css.card_login}>
                    <h1>Faça Login e mate sua fome!</h1>
                    <div>
                        <label htmlFor="email">E-mail:</label>
                        <input type="text" id="email"  />

                        <label htmlFor="senha">Senha:</label>
                        <input type="text" id="senha" />
                        <span className={css.link} onClick={() => navigate("/esqueci-minha-senha")}>Esqueceu sua senha?</span>
                    </div>
                    <div>
                        <Button variant="primary">Login</Button>
                        <div className={css.link} onClick={() => navigate("/cadastro")}>Ainda não tem conta? Cadastre-se</div>
                    </div>
                </div>
           </section>
        </>
    )
}

export default Login;