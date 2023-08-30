import React from "react";
import { Outlet } from "react-router-dom";
import Footer from "./components/Footer";
import Navbar from "./components/Navbar";

export default function Layout() {
    return (
        <>
         <Navbar />
            <Outlet />
        <Footer />
        </>   
    );
    }
