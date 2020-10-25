import React, { Component } from 'react';
import axios from 'axios';
import Jumbotron from 'react-bootstrap/Jumbotron';

import Layout from './../Partials/Layout';

import Paragraph from '../../../../Models/Paragraph';

const publicUrl = process.env.PUBLIC_URL;

/**
 * Component for showing the About Page page.
 * 
 * @component
 * @example
 * return (
 *   <About />
 * )
 */
class About extends Component {
    
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
                .get(`${publicUrl}/data/languages/english/pages/about.json`)
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
                    <Jumbotron className="page about">
                        <h2>About Me page</h2>
                        <p>This is the about me page</p>
                        <hr />
                        <div>
                            <img align="right" style={{ margin: "10px" }} src="http://placebeard.it/g/200/200" width="200" height="200" />
                            {paragraphs.map(paragraph => paragraph.toDisplay())}
                        </div>
                    </Jumbotron>
                </div>
            </Layout>
        );
    }
}

export default About;