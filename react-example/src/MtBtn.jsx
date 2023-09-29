import React, {useState} from 'react';
function MyBtn() {
    return <button>My Button</button>
    // setting state in functional component
    const [name, setName] = useState('John');
}

//
// import  Component from 'react';
// class MyBtn extends Component {
//     render() {
//         return <button>My Button</button>
//     }
//     constructor(props) {
//         super(props);
//         this.state = {
//             name: 'John'
//         }
//     }
//
// }

export default MyBtn;
