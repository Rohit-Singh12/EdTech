import { useEffect, useState } from "react";
import TabsComponent from "../components/TabsComponent"
import { NavBar } from "../components/NavBar";
import './DescriptionComponent.scss'
import { Container, Row, Col } from "react-bootstrap";
import GoogleButton from "../components/GoogleButton";
import MLIcon from '../assets/img/ml-brain.jpg';
import {CustomAccordionComponent} from "../components/CustomAccordionComponent";
const DescriptionComponent = () => {
    const [title, setTitle] = useState("Machine Learning")
    const [courseDescription, setCourseDescription] = useState("This free course on Data Structures & Algorithms in Java taught by industry excerpts helps you learn the basic concepts such as Complexity, Recursion, and the Tower of Hanoi. Best for Beginners. Start now!");
    const [courseOutline, setCourseOutline] = useState([])

    useEffect(() => {
        setCourseOutline([
            {
              header: 'Accordion Item #1',
              body: 'This is the content for Accordion Item #1.',
            },
            {
              header: 'Accordion Item #2',
              body: 'This is the content for Accordion Item #2.',
            },
            {
              header: 'Accordion Item #3',
              body: 'This is the content for Accordion Item #3.',
            }])
    },[])
    return (
       <>
            <NavBar />
            
            <div className="mt-100 p-4">
                <TabsComponent />
                <h1 className="course-info"> {title} </h1>
            </div>
            <Container>
                <Row className="description-card justify-content-center">
                    <Col md={12} lg={4} className="p-0"> 
                        <img src={MLIcon} />
                    </Col>
                    <Col md={12} lg={8} className="description-padding"> 
                        <Row className="gap-15px justify-content-center">
                            <Col xs={12}>
                                {courseDescription}
                            </Col>
                            <Col xs={12} style={{justifyContent:"center", display:"flex"}}>
                                <GoogleButton />
                            </Col>
                        </Row>
                        
                    </Col>
                </Row>
            </Container>

            <Container className="m-0" style={{maxWidth: "none"}}>
                <Row className="course-outline">
                    <Col xs={12}>
                        <h2 className="white-h3-heading"> Course Outline </h2>
                        <CustomAccordionComponent items={courseOutline}/>
                    </Col>
                </Row>
            </Container>
        </> 
    )
}

export default DescriptionComponent;    