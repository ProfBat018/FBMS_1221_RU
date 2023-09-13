// create a button component

import React from 'react';

const Button = (props) => {
    return (
        <button onClick={props.onClick}>
            {props.label}
        </button>
    )
}

export default Button;