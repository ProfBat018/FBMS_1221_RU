import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import {GoogleOAuthProvider} from "@react-oauth/google";

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <GoogleOAuthProvider clientId='104935222763-nlabhgvt1n1lf1l39fkh30cqvk8uqmj9.apps.googleusercontent.com'>
        <React.StrictMode>
            <App/>
        </React.StrictMode>
    </GoogleOAuthProvider>
);

reportWebVitals();
