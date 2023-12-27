import { Container, Nav } from "react-bootstrap";
import '../assets/scss/tabs-component.scss';

const TabsComponent = () => {
    return (
        <Container>
            <Nav variant="pills" className="nav-pills mb-5 justify-content-center align-items-center nav" defaultActiveKey="first">
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
        </Container>
    )
}

export default TabsComponent;