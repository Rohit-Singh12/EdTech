//import { Container, Nav } from "react-bootstrap";
import '../assets/scss/tabs-component.scss';

import React, { useState } from 'react';
import { Nav, Tab, Container, Row, Col } from 'react-bootstrap';
import DescriptionCard from './DescriptionCard';


const TabsComponent = ({beginner, intermediate, advanced}) => {
    const [activeKey, setActiveKey] = useState("first");
    console.log(advanced, "abc")
    const handleSelect = (key) => {
        setActiveKey(key);
    };

    return (
        <Container>
            <Row>
                <Col>
                    <Tab.Container activeKey={activeKey} onSelect={handleSelect}>
                        <Nav variant="pills" className="nav-pills mb-5 justify-content-center align-items-center nav">
                            <Nav.Item>
                                <Nav.Link eventKey="first">Beginner</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="second">Intermediate</Nav.Link>
                            </Nav.Item>
                            <Nav.Item>
                                <Nav.Link eventKey="third">Advanced</Nav.Link>
                            </Nav.Item>
                        </Nav>

                        <Tab.Content>
                            <Tab.Pane eventKey="first">
                                <p>Content for Beginner</p>
                                {/* Add your content for the Beginner level here */}
                                <DescriptionCard courseDescription={advanced.courseDescription}  courseIcon={advanced.courseIcon}/>
                            </Tab.Pane>
                            <Tab.Pane eventKey="second">
                                <p>Content for Intermediate</p>
                                {/* Add your content for the Intermediate level here */}
                                <DescriptionCard courseDescription={advanced.courseDescription}  courseIcon={advanced.courseIcon}/>
                            </Tab.Pane>
                            <Tab.Pane eventKey="third">
                                <p>Content for Advanced</p>
                                {/* Add your content for the Advanced level here */}
                                <DescriptionCard courseDescription={advanced.courseDescription}  courseIcon={advanced.image}/>
                            </Tab.Pane>
                        </Tab.Content>
                    </Tab.Container>
                </Col>
            </Row>
        </Container>
    );
};

export default TabsComponent;

// const TabsComponent = () => {
//     return (
//         <Container>
//             <Nav variant="pills" className="nav-pills mb-5 justify-content-center align-items-center nav" defaultActiveKey="first">
//                         <Nav.Item>
//                         <Nav.Link eventKey="first">Beginner</Nav.Link>
//                         </Nav.Item>
//                         <Nav.Item>
//                         <Nav.Link eventKey="second">Intermediate</Nav.Link>
//                         </Nav.Item>
//                         <Nav.Item>
//                         <Nav.Link eventKey="third">Advanced</Nav.Link>
//                         </Nav.Item>
//             </Nav>
//         </Container>
//     )
// }

//export default TabsComponent;