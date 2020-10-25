import React from 'react';
import { HashRouter as Router } from 'react-router-dom';
import Container from 'react-bootstrap/Container';
import SiteRoutes from './Sections/SiteRoutes';
import './App.css';

/**
 * Title of the site
 */
const siteName = 'Simple App React';
const publicUrl = process.env.PUBLIC_URL;

/**
 * This fuction startup the application
 * @function App
 */
function App() {
  return (
    <div id="wrapper">
        <Router basename={publicUrl}>
            <SiteRoutes />
        </Router>
    </div>
  );
}

export default App;
