import React, { useState } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faBars } from '@fortawesome/free-solid-svg-icons';
//import './YourComponent.css'; // Import your component-specific CSS file
import Card from 'react-bootstrap/Card';
import Button from 'react-bootstrap/Button';
import styles from './styles/RegisterCard.module.css';

const RegisterCard = () => {
 const [isOpen, setIsOpen] = useState(false);


  console.log("Width: " + window.innerWidth);

  const chatBoxHandler =()=>{
    if(window.innerWidth < 721){
      setIsOpen(!isOpen);
    }
  }

  return (
    <div className={styles.chat_card_main}>
      <div  className={styles.chat_card + " " + (isOpen && styles.animate_chat_box)}>
        <img src="holder.js/100px180" />
        <div>
          <div>div Title</div>
          <div>
            Some quick example text to build on the card title and make up the
            bulk of the card's content.
          </div>

        </div>
      </div>
      {(window.innerWidth < 721) && <Button  variant="primary" onClick={chatBoxHandler}>Go</Button>}
      
    </div>
  );
};

export default RegisterCard;
