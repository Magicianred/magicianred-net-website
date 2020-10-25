import React from 'react';
import PropTypes from 'prop-types';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import logo from './../../../../logo.svg';

import LanguagesSwitch from '../../../Partials/LanguagesSwitch';

const publicUrl = process.env.PUBLIC_URL;

/**
 * Functional Component for showing the header of the site. 
 * @component
 * @param {string} title Title of the site
 * @example
 * const sitename = 'my site name'
 * return (
 *   <Header title={sitename} />
 * )
 */
const Header = ({ title }) => {
    return (
        <header className="partial header" style={{ marginBottom: "15px" }}>
            <Navbar className="menu">
                <Navbar.Brand href={`${publicUrl}/#/`}>
                    {/* <img
                        src={logo}
                        width="30"
                        height="30"
                        className="d-inline-block align-top"
                        alt={`${title} logo`}
                    /> */}
                    </Navbar.Brand>
                    <Navbar.Toggle aria-controls="basic-navbar-nav" />
                    <Navbar.Collapse id="basic-navbar-nav">
                        <Nav className="mr-auto">
                            <Nav.Link className="header-link" id="home_link" href={`${publicUrl}/#/it/`}>Home</Nav.Link>
                            <Nav.Link className="header-link" id="web-project_link" href={`${publicUrl}/#/it/progetti-web`}>Progetti Web</Nav.Link>
                            <Nav.Link className="header-link" id="writer-project_link" href={`${publicUrl}/#/it/progetti-scrittura`}>Progetti Scrittura</Nav.Link>
                            <Nav.Link className="header-link" id="permacultura_link" href={`${publicUrl}/#/it/permacultura`}>Permacultura</Nav.Link>
                            <Nav.Link className="header-link" id="about_link" href={`${publicUrl}/#/it/about`}>About</Nav.Link>
                        </Nav>
                        <LanguagesSwitch />
                    </Navbar.Collapse>
            </Navbar>
            <section className="header-description">
                <div id="plandesign"><img src="/images/plans.png" alt="" /></div>
                <h1><a href="#">La Magia delle Idee <small><em>by Magicianred</em></small></a></h1>
                <p>spazio personale per dare libero sfogo alle idee. Non ci saranno solo idee concrete e pienamente sviluppate,
                ma germogli, semi, bozze e quant'altro mi verrà in mente. <br/>
                Molte saranno abbandonate, alcune vedranno la luce e si svilupperanno,
                molte altre invece saranno lasciate libere di circolare con licenze adatte per farle raccoglie a chi se la sentirà.</p>
            </section>
        </header>
    );
}

Header.propTypes = {
    /**
     * Title of the site
     */
    title: PropTypes.string.isRequired,
}

Header.defaultProps = {
    title: 'Default Site title'
}

export default Header;