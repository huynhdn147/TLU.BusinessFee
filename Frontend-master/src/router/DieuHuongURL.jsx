import React, { Component } from 'react'
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Home from '../components/Home';
import QuanLyNhanVien from '../components/QuanLyNhanVien';
import QuanLyPhongBan from '../components/QuanLyPhongBan';
import axios from 'axios';

export default class DieuHuongURL extends Component {
    render() {
        axios.get('https://localhost:5001/api/PhongBan')
            .then(function (response) {
                // handle success
                console.log(response);
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            })
            .then(function () {
                // always executed
            });
        return (
            <Switch>
                <Route exact path="/">
                    <Home />
                </Route>
                <Route path="/home">
                    <Home />
                </Route>
                <Route path="/quanlynhanvien">
                    <QuanLyNhanVien />
                </Route>
                <Route path="/quanlyphongban">
                    <QuanLyPhongBan
                        stt='1'
                        maPhongBan='aaa'
                        tenPhongBan='bbb' />

                </Route>
            </Switch >
        )
    }
}
