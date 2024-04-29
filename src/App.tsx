import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import Hero from "./Layout/HomePage/Hero/Hero";
import { Programs } from "./Layout/HomePage/Programs/Programs";
import { Reasons } from "./Layout/HomePage/Reasons/Reasons";
import "./App.css";
import { Testimonials } from "./Layout/HomePage/Testimonials/Testimonials";
import { Footer } from "./Layout/HomePage/Footer/Footer";
import { Login } from "./Layout/Login/Login";
import {HomePage} from "./Layout/HomePage/HomePage";

function App() {
  return (
    <Router>
      <div className="App">
        {/* <Hero /> */}
        <Routes>
          <Route path="/" element={<HomePage />} />{" "}
          {/* <Routes path="/login" element={<Login />} />{" "} */}
        {/*</Routes>*/}
        {/*<Programs />*/}
        {/*<Reasons />*/}
        {/*<Testimonials />*/}
        {/*<Footer />*/}
        </Routes>
      </div>
    </Router>
  );
}

export default App;
