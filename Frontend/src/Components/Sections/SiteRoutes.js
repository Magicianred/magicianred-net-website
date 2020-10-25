import React from 'react';
import { Route, Switch } from 'react-router-dom';
import ItalianSection from './ItalianSection';
// import EnglishSection from './EnglishSection';
// import SpanishSection from './SpanishSection';
// import GermanSection from './GermanSection';
import Error from '../Languages/Italian/Pages/Error';
import NotFound from '../Languages/Italian/Pages/Error';

/**
 * Functional Component for handle routes of sites.
 * 
 * @component
 * @example
 * return (
 *   <SiteRoutes />
 * )
 */
const SiteRoutes = () =>
    <Switch>
        {/* <Route path={`/en`} component={EnglishSection} />
        <Route path={`/es`} component={SpanishSection} />
        <Route path={`/de`} component={GermanSection} /> */}
        <Route path={`/`} component={ItalianSection} />
        { /* default language */ }
        <Route exact path="/error" component={Error} />
        
        <Route path="*" component={NotFound} />
    </Switch>

export default SiteRoutes;