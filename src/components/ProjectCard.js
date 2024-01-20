import { Col } from "react-bootstrap";
import {Link} from "react-router-dom";
export const ProjectCard = ({ id, title, description, imgUrl }) => {
  console.log("Response110", id,  title, description,)
  return (
    <Col size={12} sm={6} md={4}>
    <Link to={`/Description/${id}`}>
      <div className="proj-imgbx">
        <img src={imgUrl} />
        <div className="proj-txtx">
          <h4 className="projectHoverTitle">{title}</h4>
          <span className="projectHoverSpan">{description}</span>
        </div>
      </div>
      </Link>
    </Col>
  )
}
