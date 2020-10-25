import React from 'react';

const appName = process.env.REACT_APP_NAME;
const appVersion = process.env.REACT_APP_VERSION;

/**
 * Functional Component for showing the footer of the site
 * @component
 * @example
 * return (
 *  <Footer />
 * )
 */
const Footer = () => {
    return (
        <footer>
		    <section id="footer-area">
    			<section id="footer-outer-block">
					<aside class="footer-segment">
					    <h4>Friends</h4>
                        <ul>
                            <li><a href="#">one linkylink</a></li>
                            <li><a href="#">two linkylinks</a></li>
                            <li><a href="#">three linkylinks</a></li>
                        </ul>
					</aside>
					<aside class="footer-segment">
                        <h4>Awesome Stuff</h4>
                        <ul>
                            <li><a href="#">one linkylink</a></li>
                            <li><a href="#">two linkylinks</a></li>
                            <li><a href="#">three linkylinks</a></li>
                        </ul>
					</aside>
					<aside class="footer-segment">
                        <h4>Coolness</h4>
                        <ul>
                            <li><a href="#">one linkylink</a></li>
                            <li><a href="#">two linkylinks</a></li>
                            <li><a href="#">three linkylinks</a></li>
                        </ul>
					</aside>
					<aside class="footer-segment">
                        <h4>Licenza Template</h4>
                        <p><small>This work by <i>freehtml5templates.com</i> is licensed under a
                        <i>Creative Commons Attribution 3.0</i> United States License.</small></p>
					</aside>
			    </section>
                {/* <p>
                    <small>This is the footer <i>{appName}</i> version <b>{appVersion}</b></small>
                </p> */}
            </section>
        </footer>
    )
}

export default Footer;