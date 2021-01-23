import DieuHuongURL from '../router/DieuHuongURL';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import './App.css';
import Footer from './Footer';
import Header from './Header';
import Nav from './Nav';
import axios from 'axios';
import React, { Component } from 'react';
import AlertComponent from './AlertComponent';

// https://localhost:5001/api/PhongBan
class App extends Component {
    render() {
        return (
            <Router>
                <div>
                    {/* 143 */}
                    <AlertComponent></AlertComponent>
                    <Header></Header>
                    <div class="row">
                        <Nav></Nav>
                        <DieuHuongURL></DieuHuongURL>
                    </div>

                    <Footer></Footer>
                </div>
            </Router>
        );
    }
}



export default App;
