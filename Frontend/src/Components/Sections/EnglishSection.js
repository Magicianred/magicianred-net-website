import React from 'react';
import { Route, withRouter } from 'react-router-dom';
import Home from '../Languages/English/Pages/Home';
import About from '../Languages/English/Pages/About';
import Classes from '../Languages/English/Pages/Classes';
import Contact from '../Languages/English/Pages/Contact';

/**
 * Functional Component for handle routes to About Section.
 * 
 * @component
 * @example
 * return (
 *   <EnglishSection />
 * )
 */
const EnglishSection = withRouter(props =>
    <>
        <Route exact path={`${props.match.url}`} component={Home} />
        <Route exact path={`${props.match.url}/about`} component={About} />
        <Route exact path={`${props.match.url}/classes`} component={Classes} />
        <Route exact path={`${props.match.url}/contact`} component={Contact} />
    </>
);

export default EnglishSection;