import React from 'react';
import '../assets/scss/GoogleButton.scss';
import { ReactComponent as GoogleLogo } from '../assets/img/icons8-google.svg';

const GoogleButton = () => {
  const handleGoogleLogin = () => {
    console.log('Logged in with Google');
  };

  return (
    <button className="google-button" onClick={handleGoogleLogin}>
      <GoogleLogo className="google-logo"/>
      <span className="button-text">Enroll with Google</span>
    </button>
  );
};

export default GoogleButton;
