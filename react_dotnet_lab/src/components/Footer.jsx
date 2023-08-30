import React from "react";
const Footer = () => {
  const currentYear = new Date().getFullYear();
  return (
    <>
      <footer className="footer">
        <p>&copy;Bibek Angdembe {currentYear}</p>
      </footer>
    </>
  );
};
export default Footer;
