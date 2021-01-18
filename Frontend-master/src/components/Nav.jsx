import React, { Component } from 'react'
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";

export default class Nav extends Component {
    render() {
        return (
            <div className="col-2">
                <div className="list-group ">
                    <a href="#" className="list-group-item list-group-item-action disabled mt-3">QLGV</a>
                    <Link to="/quanlyphongban" className="list-group-item list-group-item-action">Quản lý phòng ban</Link>
                    <Link to="/quanlynhanvien" className="list-group-item list-group-item-action">Quản lý nhân viên</Link>
                </div>
            </div>

        )
    }
}
