import React from "react";
import { useEffect,useState } from "react";
import ImageProfile from "./assets/test.jpg"

const Home = () => {
  

  return (
    <>
      <div className="home__container">
        <h1>Home</h1>
       
      <div>
        <img src={ImageProfile} alt="profile" height={200} width={200} style={{borderRadius:'50%'}}/>
      </div>
      </div>
    </>
  )
}
export default Home


