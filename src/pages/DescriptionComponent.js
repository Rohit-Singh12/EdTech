import { useEffect, useState } from "react";
import TabsComponent from "../components/TabsComponent"
import { NavBar } from "../components/NavBar";
import './DescriptionComponent.scss'
import { Container, Row, Col } from "react-bootstrap";
import GoogleButton from "../components/GoogleButton";
import MLIcon from '../assets/img/ml-brain.jpg';
import { CustomAccordionComponent } from "../components/CustomAccordionComponent";
import InstructorInfo from "../components/InstructorInfo";
import Carousel from "react-multi-carousel";
import RegisterCard from "../components/RegisterCard";
import DescriptionCard from '../components/DescriptionCard';

const DescriptionComponent = () => {
  const [title, setTitle] = useState("Machine Learning");
  const [courseDescription, setCourseDescription] = useState("This free course on Data Structures & Algorithms in Java taught by industry excerpts helps you learn the basic concepts such as Complexity, Recursion, and the Tower of Hanoi. Best for Beginners. Start now!");
  const [courseOutline, setCourseOutline] = useState([]);
  const [instructorInfoList, setInstructorInfoList] = useState([]);

  const [course, setCourse] = useState([]);

  useEffect(()=>{
    setCourse([
      {
        title: "Advanced Machine Learning",
        courseDescription: "world's best course",
        level: "Advanced",
        image: MLIcon
      },
      {
        title: "Intermediate Machine Learning",
        courseDescription: "world's best course",
        level: "Intermediate",
        image: MLIcon
      },
      {
        title: "Basic Machine Learning",
        courseDescription: "world's best course",
        level: "Basic",
        image: MLIcon
      }
    ])
  },[])
  /**
   * Fill course outline
   */
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
  }, [])

  /**
   * Fill instructor data
   */
  useEffect(() => {
    setInstructorInfoList([
      {
        name: "Ketan Janai",
        designation: "Sr. Software Engineer, Ex-Walmart, Ex- Paypal, IIT-BHU Alumnus",
        lerners: "1.7L+",
        coursesServed: "3",
        yearsOfexp: "1",
        bio: "A Software engineer with 9+ years of experience working in major product companies like Walmart, Paypal, Oracle, etc. He also has a passion for mentoring students and helping professionals crack their dream jobs in Software Engineering.",
        img: ""
      },
      {
        name: "Rahul Patil",
        designation: "Sr. Software Engineer, Ex-Walmart, Ex- Paypal, IIT-BHU Alumnus",
        lerners: "1.7L+",
        coursesServed: "3",
        yearsOfexp: "1",
        bio: "A Software engineer with 9+ years of experience working in major product companies like Walmart, Paypal, Oracle, etc. He also has a passion for mentoring students and helping professionals crack their dream jobs in Software Engineering.",
        img: ""
      },
      {
        name: "Nishant Hipparagi",
        designation: "Sr. Software Engineer, Ex-Walmart, Ex- Paypal, IIT-BHU Alumnus",
        lerners: "1.7L+",
        coursesServed: "3",
        yearsOfexp: "1",
        bio: "A Software engineer with 9+ years of experience working in major product companies like Walmart, Paypal, Oracle, etc. He also has a passion for mentoring students and helping professionals crack their dream jobs in Software Engineering.",
        img: ""
      }
    ]
    )
  }, [])

  const responsive = {
    desktop: {
      breakpoint: { max: 3000, min: 1024 },
      items: 1,
      slidesToSlide: 1 // optional, default to 1.
    },
    tablet: {
      breakpoint: { max: 1024, min: 768 },
      items: 1,
      slidesToSlide: 1 // optional, default to 1.
    },
    mobile: {
      breakpoint: { max: 767, min: 464 },
      items: 1,
      slidesToSlide: 1 // optional, default to 1.
    }
  };

  return (
    <>
      <NavBar />
      <div className="mt-100 p-4">
        <TabsComponent 
        beginner={course.find(item=>item.level==="Basic")} 
        intermediate={course.find(item=>item.level==="Intermediate")} 
        advanced={course.find(item=>item.level==="Advanced")} 
        />
        </div>
        <div className="desktop-description">
          <h1 className="course-info"> {title} </h1>


        <DescriptionCard/>


        <Container className="m-0" style={{ maxWidth: "none" }}>
          <Row className="course-outline">
            <Col xs={12}>
              <h2 className="white-h3-heading"> Course Outline </h2>
              <CustomAccordionComponent items={courseOutline} />
            </Col>
          </Row>
        </Container>
        <div className="instructor__info">
          <Carousel
            responsive={responsive}
            autoPlay={true}
            swipeable={true}
            draggable={true}
            showDots={true}
            infinite={true}
            partialVisible={false}>
            {instructorInfoList.map((instructorInfo, index) => {
              return (
                <div className="slider" key={index}>
                  <InstructorInfo instructorInfo={instructorInfo} />
                </div>
              );
            })}
          </Carousel>
        </div>
      </div>

      {/* <div className="mb-4  btn-sticky">
                <RegistrationCard/>
                <GoogleButton />
            </div> */}

      <RegisterCard />
    </>
  )
}

export default DescriptionComponent;    