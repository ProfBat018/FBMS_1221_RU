import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./home";
import Login from "./login";
import "./App.css";
import { useEffect, useState } from "react";
import Register from "./register";

function App() {
  const [username, setUsername] = useState("");

  useEffect(() => {}, []);

  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home username={username} />} />
          <Route path="/login" element={<Login setUsername={setUsername} />} />
          <Route
            path="/register"
            element={<Register setUsername={setUsername} />}
          />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
