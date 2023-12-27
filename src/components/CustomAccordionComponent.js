import React from 'react';
import { Accordion, Card } from 'react-bootstrap';
import '../assets/scss/StyledAccordian.scss'; // Import your SCSS file for styles
 
export const CustomAccordionComponent = ({items}) => {
  return (
    <Accordion className="accordion-container">
    {items.map((item, index) => (
        <Accordion.Item key={index} eventKey={index.toString()}>
          <Accordion.Header>{item.header}</Accordion.Header>
          <Accordion.Body className="accordion-body">{item.body}</Accordion.Body>
        </Accordion.Item>
      ))}

    </Accordion>
  )
}

