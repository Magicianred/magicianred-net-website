import React from 'react';
import { Route, withRouter } from 'react-router-dom';
import Home from '../Languages/German/Pages/Home';
import About from '../Languages/German/Pages/About';
import Classes from '../Languages/German/Pages/Classes';
import Contact from '../Languages/German/Pages/Contact';

/**
 * Functional Component for handle routes to About Section.
 * 
 * @component
 * @example
 * return (
 *   <GermanSection />
 * )
 */
const GermanSection = withRouter(props =>
    <>
        <Route exact path={`${props.match.url}`} component={Home} />
        <Route exact path={`${props.match.url}/about`} component={About} />
        <Route exact path={`${props.match.url}/classes`} component={Classes} />
        <Route exact path={`${props.match.url}/contact`} component={Contact} />
    </>
);

export default GermanSection;