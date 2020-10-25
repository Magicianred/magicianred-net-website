import React, { Component } from 'react';
import axios from 'axios';
import Jumbotron from 'react-bootstrap/Jumbotron';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import ListGroup from 'react-bootstrap/ListGroup';
import Badge from 'react-bootstrap/Badge';

import Layout from '../Partials/Layout';
import Paragraph from '../../../../Models/Paragraph';
import Course from '../../../../Models/Course';

const publicUrl = process.env.PUBLIC_URL;

/**
 * Component for showing the Classes page.
 * 
 * @component
 * @example
 * return (
 *   <Classes />
 * )
 */
class Classes extends Component {
    
    constructor(props) {
        super(props);
        this.state = {
            classes: [],
            paragraphs: [],
            currentClassId: undefined,
            hasError: false,
        };
    }

    componentDidMount() {
        const classes = [];
        this.serverRequest = 
            axios
                .get(`${publicUrl}/data/languages/english/classes.json`)
                .then((result) => {
                    result.data.map((item, index) => classes.push(new Course(item.id, item.title, item.text, item.datestart, item.dateend, item.imagesrc)));
                    let currentClassId = undefined;
                    if (classes && classes.length > 0) currentClassId = classes[0].id;
                    this.setState({ classes, currentClassId });
            });
            const paragraphs = [];
            this.serverRequest = 
                axios
                    .get(`${publicUrl}/data/languages/english/pages/classes.json`)
                    .then((result) => {
                        result.data[0].paragraphs.map((item, index) => paragraphs.push(new Paragraph(index, item.text)));
                        this.setState({ paragraphs });
                });
    }

    static getDerivedStateFromError(error) {       
        return { hasError: true };  
    }

    onShowClass = (classId) => {
        this.setState({ currentClassId: classId });
    }

    render() {
        const { classes, paragraphs, currentClassId, hasError } = this.state;
        return (
            <Layout>
                {hasError ? <h1>Something went wrong.</h1> : null}
                <div className="page">
                    <Container>
                        <Row>
                            <Col sm={8}>
                                <Jumbotron className="page classes">
                                    <h2>Our Classes</h2>
                                    <p>This is the classes page</p>
                                    <hr />
                                    {paragraphs.map(paragraph => paragraph.toDisplay())}
                                    {classes && classes.length > 0 ?
                                        <ListGroup>
                                        {classes.map((course, index) =>
                                            <ListGroup.Item key={index} action onClick={() => this.onShowClass(course.id)}>
                                            {course.title} <Badge variant="secondary">show details</Badge>
                                            </ListGroup.Item>)}
                                            </ListGroup> : null}
                                </Jumbotron>
                            </Col>
                            <Col sm={4}>
                                {classes && classes.length > 0 ?
                                    classes.map(course => (course.id === currentClassId) ?
                                        course.toDisplay() : null) 
                                    : null}
                            </Col>
                        </Row>
                    </Container>
                </div>
            </Layout>
        );
    }
}

export default Classes;