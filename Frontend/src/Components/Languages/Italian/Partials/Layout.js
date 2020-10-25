import React from 'react';
import Header from './Header';
import Footer from './Footer';

/**
 * Title of the site
 */
const siteName = 'La Magia delle Idee by Magicianred';

const Layout = (props) =>
    <>
        <Header title={siteName} />
        <section id="main">
			<section id="content">
                {props.children}
            </section>
            <aside id="sidebar">
				<h3>Wiball</h3>
				<figure>
				  <img width="226" height="186" src="/images/wiball_onkeyboard.png" alt="Wiball on keybord (C) Elisa Ragni 2010 by-nc-nd-3.0" />
				  <figcaption>Wiball, la simpatica pallina che è seduta sulla tastiera, mascotte del progetto xnowi.
					<br />Realizzata da <a href="http://www.facebook.com/pages/Elisa-Ragni/159242230776374" title="Visita la pagina facebook di 'Elisa Ragni'">
						Elisa Ragni</a></figcaption>
				</figure>
				<br/><br/>
				<h3>Cose da fare...</h3>
                <ul>
                    <li><a href="#">Migliorare le lingue straniere</a></li>
                    <li><a href="#">Scrivere più racconti</a></li>
                    <li><a href="#">Trasformare l'esperienza dello sviluppo nella progettualità</a></li>
                    <li><a href="#">Rendere stabile progetto XNOWI e comunicare meglio l'idea</a></li>
                    <li><a href="#">Completare questo sito</a></li>
                </ul>
				<br/><br/>
				<h3>I miei social</h3>
                <ul>
                    <li><a href="http://twitter.com/Magicianred79" rel="nofollow">Twitter</a></li>
                    <li><a href="https://magicianred.github.io">Simone Paolucci [me]</a></li>
                    <li><a href="https://magicianred.altervista.org/home.php">Magicianred Web Blog</a></li>
                </ul>
				<h3>Banner</h3>
                <img width="125" height="125" src="/images/ad125.jpg" alt="" />
                <img width="125" height="125" src="/images/ad125.jpg" alt="" /><br />
                <img width="125" height="125" src="/images/ad125.jpg" alt="" />
                <img width="125" height="125" src="/images/ad125.jpg" alt="" /><br /><br />
    		</aside>
        </section>
        <Footer />
    </>

export default Layout;