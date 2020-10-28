import React, {Component} from 'react'
import Navbar from './Navbar';

export default class Orders extends Component{
    constructor(props) {
        super(props);
        this.state = {
            value: '',
            orderid: 0,
            stock: 0,
            user: 0,
            total: 0
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
      }
    
      handleChange(event) {this.setState({[event.target.name]: event.target.value});}
      handleSubmit(event) {
        alert('was submitted: ' + this.state.value);
        event.preventDefault();
      }
    
    render(){
        return(
            <section>
                <Navbar/>
                <div className = "card">
                    <div className = "card-content">
                        <h6 className = "mt-bottom">
                            <strong>ORDERS</strong>
                        </h6>
                        <p className ="grey-text">
                        </p>
                    </div>
                    <div className = "card-action">
                        <h6><strong>ORDER INFO</strong></h6>
                        <div className = "row mt">
                            <div className = "col s12 m6 l6 xl6">
                                <p> </p>
                                <p><strong>Order ID: </strong></p> {/*Kan verander word om n table ook te wys lees data in hier*/}
                                <p><strong>Stock ID: </strong></p>
                                <p><strong>User ID: </strong></p>
                                <p><strong>Order Total: </strong></p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    Search by Order ID:
                                    <input type="text" orderid={this.state.orderid} onChange={this.handleChange} />        </label>
                                    <input type="submit" value="Search" />
                                </p>
                            </div>                            
                        </div>
                    </div>
                </div>
                <div className = "card">
                    <div className = "card-content">
                        <h6 className = "mt-bottom">
                            <strong></strong>
                        </h6>
                        <p className ="grey-text">
                        </p>
                    </div>
                    <div className = "card-action">
                        <h6><strong>New Orders</strong></h6>
                        <div className = "row mt">
                            <div className = "col s12 m6 l6 xl6">
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Stock ID: </strong>
                                        <input type="text" stock={this.state.stock} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User ID: </strong>
                                        <input type="text" user={this.state.user} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Order Total: </strong>
                                        <input type="text" total={this.state.total} onChange={this.handleChange} />        
                                    </label>
                                    <input type="submit" value="Submit" />
                                </p>
                            </div>                            
                        </div>
                    </div>
                </div>
                <div className = "card">
                    <div className = "card-content">
                        <h6 className = "mt-bottom">
                            <strong></strong>
                        </h6>
                        <p className ="grey-text">
                        </p>
                    </div>
                    <div className = "card-action">
                        <h6><strong>Update Orders</strong></h6>
                        <div className = "row mt">
                            <div className = "col s12 m6 l6 xl6">
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                        Order ID:
                                        <input type="text" orderid={this.state.orderid} onChange={this.handleChange} />
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Stock ID: </strong>
                                        <input type="text" stock={this.state.stock} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Order Total: </strong>
                                        <input type="text" total={this.state.total} onChange={this.handleChange} />        
                                    </label>
                                    <input type="submit" value="Submit" />
                                </p>
                            </div>                            
                        </div>
                    </div>
                </div>
            </section>

        );
        }
}