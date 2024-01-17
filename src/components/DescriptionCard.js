import '../pages/DescriptionComponent.scss';
import { Container, Row, Col } from "react-bootstrap";
import GoogleButton from "../components/GoogleButton";
import MLIcon from '../assets/img/ml-brain.jpg';
const DescriptionCard=({courseIcon, courseDescription})=>{
  console.log(courseDescription, courseIcon, "abc");
    return(
        <Container>
          <Row className="description-card justify-content-center">
            <Col md={12} lg={4} className="p-0">
              <img src={courseIcon} />
            </Col>
            <Col md={12} lg={8} className="description-padding">
              <Row className="gap-15px justify-content-center">
                <Col xs={12}>
                 {courseDescription}
                </Col>
                <Col xs={12} style={{ justifyContent: "center", display: "flex" }}>
                  <GoogleButton />
                </Col>
              </Row>

            </Col>
          </Row>
        </Container>
    );
}
export default DescriptionCard;