import React, { Component } from 'react';
import axios from 'axios';
import Jumbotron from 'react-bootstrap/Jumbotron';

import Layout from './../Partials/Layout';

import Paragraph from '../../../../Models/Paragraph';

const publicUrl = process.env.PUBLIC_URL;

/**
 * Component for showing the Contact Page page.
 * 
 * @component
 * @example
 * return (
 *   <Contact />
 * )
 */
class Contact extends Component {
    
    constructor(props) {
        super(props);
        this.state = {
            paragraphs: [],
            hasError: false,
        };
    }        

    componentDidMount() {
        const paragraphs = [];
        this.serverRequest = 
            axios
                .get(`${publicUrl}/data/languages/english/pages/contact.json`)
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

    render() {
        const { items, paragraphs, hasError } = this.state;
        return (
            <Layout>
                {hasError ? <h1>Something went wrong.</h1> : null}
                <div className="page">
                    <Jumbotron className="page contact">
                        <h2>Contact Me page</h2>
                        <p>This is the Contact me page</p>
                        <hr />
                        <div>
                            {paragraphs.map(paragraph => paragraph.toDisplay())}
                        </div>
                    </Jumbotron>
                </div>
            </Layout>
        );
    }
}

export default Contact;