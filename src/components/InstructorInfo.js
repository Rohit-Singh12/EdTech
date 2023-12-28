import { Container, Row, Col } from "react-bootstrap";
import { ReactComponent as GoogleLogo } from '../assets/img/icons8-google.svg';
import '../assets/scss/InstructorInfo.scss';
const InstructorInfo = ({instructorInfo}) => {
    console.log(instructorInfo)
    return (
        <Container className="pl-1 pr-1 pt-4 pb-4 instructor-card gap-15px">
                <Row className="w-100">
                      <Col sm={12} md={4} className="instructor-img">
                            <GoogleLogo />
                      </Col>
                      <Col sm={12} md={8}>
                        <div class="instructor-info">
                           <div class="instructor-info__top">
                                <p class="instructor-info__name"> {instructorInfo.name}</p>
                                <p class="instructor-info__designation">{instructorInfo.designation}</p>
                            </div>
                            <div class="instructor-info__bottom">
                                <div class="info">
                                    <div class="icon">
                                        <img class="lazy gl-lazy-loaded fadeIn" src="https://d1vwxdpzbgdqj.cloudfront.net/corporate-pass/icons/learner_icon.webp" alt="learner icon" data-loaded="true"/>
                                    </div>
                                <div class="text">{instructorInfo.lerners} Learners</div>
                            </div>
                            <div class="info">
                                <div class="icon">
                                    <img class="lazy gl-lazy-loaded fadeIn" src="https://d1vwxdpzbgdqj.cloudfront.net/corporate-pass/icons/video_icon.webp" alt="video icon" data-loaded="true"/>
                                </div>
                                <div class="text">{instructorInfo.coursesServed} Courses</div>
                            </div>
                        </div>
                        </div>
                      </Col>
                </Row>
                <Row>
                        <Col xs={12}>
                             <div class="instructor-card__bottom" data-max-word-count="40"><p>{instructorInfo.bio}</p></div>
                        </Col>
                </Row>
            </Container>
    )
}

export default InstructorInfo;