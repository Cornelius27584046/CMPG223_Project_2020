import React, {Component} from 'react'
import Navbar from './Navbar';

export default class Users extends Component{
    constructor(props) {
        super(props);
        this.state = {
            value: '',
            search: '',
            name: '',
            surname: '',
            contact: '',
            descg:'',
            streetnr: '',
            streetn: '',
            suburb: '',
            town: '',
            pcode: 0,
            mednr : 0,
            hname: '',
            hsurname: '',
            medname: '',
            eye: false,
            email: '',
            pass: ''

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
                <div>
                <div className = "card">
                    <div className = "card-content">
                        <h6 className = "mt-bottom">
                            <strong>USERS</strong>
                        </h6>
                        <p className ="grey-text">
                        </p>
                    </div>
                    <div className = "card-action">
                        <h6><strong>USER INFO</strong></h6>
                        <div className = "row mt">
                            <div className = "col s12 m6 l6 xl6">
                                <p><strong>User ID: </strong></p>
                                <p><strong>User Name: </strong></p>
                                <p><strong>User Surname: </strong></p>
                                <p><strong>User Contact Details: </strong></p>
                                <p className = 'white-text'><strong>____</strong></p>
                                <p><strong>Medical Aid ID: </strong></p>
                                <p><strong>Medical Aid Number: </strong></p>
                                <p><strong>Head of Medical Aid Name: </strong></p>
                                <p><strong>Head of Medical Aid Surname: </strong></p>
                                <p><strong>Medical Aid Name: </strong></p>
                                <p><strong>Eye Care Covered: </strong></p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                        Search by User ID:
                                        <input type="text" search={this.state.search} onChange={this.handleChange} />
                                    </label>
                                    <input type="submit" value="Search" />
                                </p>

                            </div>
                            <div className = "s12 m6 l6 xl6">
                                <p><strong>Street Number: </strong></p>
                                <p><strong>Street Name: </strong></p>
                                <p><strong>Suburb: </strong></p>
                                <p><strong>Town: </strong></p>
                                <p><strong>Postal Code: </strong></p>
                                <p className = 'white-text'><strong>____</strong></p>
                                <p><strong>Email: </strong></p>
                                <p><strong>Password?: </strong></p>
                            </div>
                        </div>

                    </div>
                    <div className = "card-action">
                        <h6><strong>NEW USER</strong></h6>
                        <div className = "row mt">
                            <div className = "col s12 m6 l6 xl6">
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User Name: </strong>
                                        <input type="text" name={this.state.name} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User Surname: </strong>
                                        <input type="text" surname={this.state.surname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User Contact Details:</strong>
                                        <input type="text" contact={this.state.contact} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Desegnation:</strong>
                                        <input type="text" descg={this.state.descg} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Email:</strong>
                                        <input type="text" email={this.state.email} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Password?: </strong>
                                        <input type="Password" pass={this.state.pass} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p className = 'white-text'><strong>Medical Aid</strong></p>
                                <p><strong>Medical Aid</strong></p>   
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Medical Aid Number:</strong>
                                        <input type="text" mednr={this.state.mednr} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Head of Medical Aid Name:</strong>
                                        <input type="text" hname={this.state.hname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Head of Medical Aid Surname:</strong>
                                        <input type="text" hsurname={this.state.hsurname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Medical Aid Name:</strong>
                                        <input type="text" medname={this.state.medname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Eye Care Covered:</strong>
                                        <input type="text" eye={this.state.eye} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p className = 'white-text'><strong>Medical Aid</strong></p>
                                <p><strong>Address Details</strong></p>  
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Street Number: </strong>
                                        <input type="text" streetnr={this.state.streetnr} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Street Name: </strong>
                                        <input type="text" streetn={this.state.streetn} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Suburb: </strong>
                                        <input type="text" suburb={this.state.suburb} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Town:  </strong>
                                        <input type="text" town={this.state.town} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Postal Code: </strong>
                                        <input type="text" pcode={this.state.pcode} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <input type="submit" value="Submit" />
                            </div>
                        </div>

                    </div>
                    <div className = "card-action">
                        <h6><strong>UPDATE USER INFO</strong></h6>
                        <div className = "row mt">
                            <div className = "col s12 m6 l6 xl6">
                            <p onSubmit={this.handleSubmit}>
                                    <label>
                                        User ID to search data?:
                                        <input type="text" search={this.state.search} onChange={this.handleChange} />
                                    </label>
                                    <input type="submit" value="Search" />
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User Name: </strong>
                                        <input type="text" name={this.state.name} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User Surname: </strong>
                                        <input type="text" surname={this.state.surname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>User Contact Details:</strong>
                                        <input type="text" contact={this.state.contact} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Email:</strong>
                                        <input type="text" contact={this.state.contact} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Password?: </strong>
                                        <input type="text" contact={this.state.contact} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p className = 'white-text'><strong>Medical Aid</strong></p>
                                <p><strong>Medical Aid</strong></p>   
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Medical Aid Number:</strong>
                                        <input type="text" mednr={this.state.mednr} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Head of Medical Aid Name:</strong>
                                        <input type="text" hname={this.state.hname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Head of Medical Aid Surname:</strong>
                                        <input type="text" hsurname={this.state.hsurname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Medical Aid Name:</strong>
                                        <input type="text" medname={this.state.medname} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Eye Care Covered:</strong>
                                        <input type="text" eye={this.state.eye} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p className = 'white-text'><strong>Medical Aid</strong></p>
                                <p><strong>Address Details</strong></p>  
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Street Number: </strong>
                                        <input type="text" streetnr={this.state.streetnr} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Street Name: </strong>
                                        <input type="text" streetn={this.state.streetn} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Suburb: </strong>
                                        <input type="text" suburb={this.state.suburb} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Town:  </strong>
                                        <input type="text" town={this.state.town} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <p onSubmit={this.handleSubmit}>
                                    <label>
                                    <strong>Postal Code: </strong>
                                        <input type="text" pcode={this.state.pcode} onChange={this.handleChange} />        
                                    </label>
                                </p>
                                <input type="submit" value="Submit" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            </section>
        );
        }
}