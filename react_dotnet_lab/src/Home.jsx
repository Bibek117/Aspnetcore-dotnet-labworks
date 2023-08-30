import React from "react";
import { useEffect,useState } from "react";


const Home = () => {
  const [ImageProfile,setImageProfile] = useState("")
  useEffect(() => {
    const Interval = setInterval(()=>{
      fetch("https://randomuser.me/api/")
    .then((response) => response.json())
    .then((data) => {
      setImageProfile(data.results[0].picture.large)
    })
    },3000)
    return () => clearInterval(Interval)
  },[])

  return (
    <>
      <div className="home__container">
        <h1>Home</h1>
        <p>
          Random user profile image every 3 seconds
        </p>
      <div>
        <img src={ImageProfile} alt="profile" style={{borderRadius:'50%'}}/>
      </div>
      </div>
    </>
  )
}
export default Home


