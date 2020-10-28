import React, {Component} from 'react';
import {NavLink} from 'react-router-dom';

export default class Navbar extends Component{
    render(){
        return(
            <div>
                <nav className = "blue darken-4">
                    <div className = "container">
                        <div className = "nav-wrapper">
                            <NavLink to = "/" className = "brand-logo">
                                SpecTecular
                            </NavLink>
                            <NavLink to = "/" data-target = "side-nav" className = "sidenav-trigger">
                                <i className = "Name"></i>
                            </NavLink> 
                            <ul className = 'right hide-on-med-and-down'>
                                <li>
                                    <NavLink to = "/">
                                        <i className = "Name"><strong>Home</strong></i>
                                    </NavLink>
                                </li>
                                <li>
                                    <NavLink to = "/User">
                                        <i className = "Name">User</i>
                                    </NavLink>
                                </li>
                                <li>
                                    <NavLink to = '/Orders'>
                                        <i className = "Name">Orders</i>
                                    </NavLink>
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>
                <ul className = 'sidenav' id = 'side-nav'>
                    <li>
                        <NavLink to = "/">
                            <i className = "fas fa-home">Home</i>
                        </NavLink>
                    </li>
                    <li>
                        <NavLink to = "/User">
                            <i className = "Name">User</i>
                        </NavLink>
                    </li>
                    <li>
                    <NavLink to = '/Order'>
                        <i className = "Name">Order</i>
                    </NavLink>
                    </li>
                </ul>
            </div>
        )
    }
}