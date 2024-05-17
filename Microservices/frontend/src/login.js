import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

const Login = (props) => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [passwordError, setPasswordError] = useState("");

  const navigate = useNavigate();

  const onButtonClick = () => {
    setPasswordError("");

    if ("" === password) {
      setPasswordError("Please enter a password");
      return;
    }

    if (password.length < 7) {
      setPasswordError("The password must be 8 characters or longer");
      return;
    }

    logIn();
  };

  // fetch from https://auth-service:7266/api/Auth/Login

  /* Request body {
        "userName": "string",
        "password": "string"
    }
  */

  const logIn = () => {
    console.log(`start of fetch ${username} ${password}`);
    fetch("https://localhost:7266/api/Auth/Login", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ username, password }),
    }).then((r) => {
      if (200 === r.status) {
        console.log(r);
        // read from readable stream

        let reader = r.body.getReader();
        reader.read().then(({ done, value }) => {
          let str = new TextDecoder().decode(value);
          console.log(str);
        });
      } else {
        window.alert("Wrong email or password");
      }
    });
  };
  return (
    <div className={"mainContainer"}>
      <div className={"titleContainer"}>
        <div>Login</div>
      </div>
      <br />
      <div className={"inputContainer"}>
        <input
          value={username}
          placeholder="Enter your username here"
          onChange={(ev) => setUsername(ev.target.value)}
          className={"inputBox"}
        />
      </div>
      <br />
      <div className={"inputContainer"}>
        <input
          value={password}
          placeholder="Enter your password here"
          onChange={(ev) => setPassword(ev.target.value)}
          className={"inputBox"}
        />
        <label className="errorLabel">{passwordError}</label>
      </div>
      <br />
      <div className={"inputContainer"}>
        <input
          className={"inputButton"}
          type="button"
          onClick={onButtonClick}
          value={"Log in"}
        />
      </div>
    </div>
  );
};

export default Login;
