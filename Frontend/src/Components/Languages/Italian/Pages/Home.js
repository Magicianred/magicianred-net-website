import React, { Component } from 'react';
import axios from 'axios';
import Jumbotron from 'react-bootstrap/Jumbotron';
import Carousel from 'react-bootstrap/Carousel';

import Layout from './../Partials/Layout';
import Paragraph from '../../../../Models/Paragraph';
import HomeMessage from '../../../../Models/HomeMessage';

const publicUrl = process.env.PUBLIC_URL;

/**
 * Component for showing the Home page.
 * 
 * @component
 * @example
 * return (
 *   <Home />
 * )
 */
class Home extends Component {
    
    constructor(props) {
        super(props);
        this.state = {
            items: [],
            paragraphs: [],
            hasError: false,
        };
    }        

    componentDidMount() {
        const items = [];
        this.serverRequest = 
            axios
                .get(`${publicUrl}/data/languages/english/home_messages.json`)
                .then((result) => {
                    result.data.map((item, index) => items.push(new HomeMessage(index, item.title, item.text, item.imagesrc)));
                    this.setState({ items });
            });
        const paragraphs = [];
        this.serverRequest = 
            axios
                .get(`${publicUrl}/data/languages/english/pages/home.json`)
                .then((result) => {
                    result.data[0].paragraphs.map((item, index) => paragraphs.push(new Paragraph(index, item.text)));
                    this.setState({ paragraphs });
            });
    }

    // componentWillUnmount() {
    //     if (this.serverRequest) {
    //         this.serverRequest.abort();
    //     }
    // }

    static getDerivedStateFromError(error) {       
        return { hasError: true };  
    }    

    render() {
        const { items, paragraphs, hasError } = this.state;
        return (
            <Layout>
                {hasError ? <h1>Something went wrong.</h1> : null}
                <article>
							<h2><a href="#">Premessa</a></h2>
							<p>Al momento non ci sono articoli, ho solo impostato l'aspetto del sito ed alcune idee.</p>
						</article>
        		<article>
							<h2><a href="#">First Article Title</a></h2>
							<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur sodales ligula in libero. Sed dignissim lacinia nunc. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla.</p>
						</article>
						
        		<article>
							<h2><a href="#">Second Article Title</a></h2>
							<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur sodales ligula in libero. Sed dignissim lacinia nunc.</p>
							<p>Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.</p>
							<p>Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.</p>
						</article>
            </Layout>
        );
    }
}

export default Home;