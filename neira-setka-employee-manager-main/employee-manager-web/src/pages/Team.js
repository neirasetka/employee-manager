import Title from "components/landing/Title";
import TeamCard from "components/landing/TeamCard";
import Image1 from "assets/img/dina.jpg";
import Image2 from "assets/img/dzenita.jpg";
import Image3 from "assets/img/safija.jpg";
import DefaultNavbar from "components/DefaultNavbar";
import React, { Component } from "react";
import "pages/EmployeeCss.css";

export default function Team() {
  return (
    <section className="bg-profile-background bg-cover bg-center absolute top-0 w-full h-full">
      <div className="container max-w-7xl mx-auto px-4">
        <DefaultNavbar />
        <Title heading="Our team"></Title>
        <div className="flex flex-wrap -mt-12 justify-center">
          <TeamCard img={Image1} name="Dina Bjelić" position="Developer" />
          <TeamCard img={Image2} name="Dženita Alibegić" position="Designer" />
          <TeamCard img={Image3} name="Safija Hubljar" position="Developer" />
        </div>
      </div>
    </section>
  );
}
