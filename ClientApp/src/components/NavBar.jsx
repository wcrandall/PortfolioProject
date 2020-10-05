import React, { Component } from 'react';
import './navbar.css'; 

class NavBar extends Component {
    render() { 
        const urls = this.props.pageUrls;
        console.log(urls); 
        return ( 
            <nav className="site-header sticky-top py-1">
                <div className="container d-flex flex-column flex-md-row justify-content-between" id="navbarNav">
                        {urls.map((url)=>{
                            return(
                                <a className="py-2 d-none d-md-inline-block" key={url.id} href={url.url}>{url.name}</a>
                            );
                        })}
                    
                </div>
            </nav>
         );
    }
}
 
export default NavBar;