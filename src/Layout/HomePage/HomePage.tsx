import React from 'react';
import { Header } from './Header/Header';
import Hero from "./Hero/Hero";
import { Reasons } from './Reasons/Reasons';
import { Testimonials } from './Testimonials/Testimonials';
import { Footer } from './Footer/Footer';

export const HomePage = () => {
    return (
        <div>
            {/*<Header />*/}
            <Hero />
            <Reasons />
            <Testimonials />
            <Footer />
        </div>
    );
};