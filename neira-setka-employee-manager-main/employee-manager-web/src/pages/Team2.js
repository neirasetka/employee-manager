import { useEffect, useState } from "react";
import { getTeam } from "services/TeamService";
import React, { Component } from "react";
import H3 from "@material-tailwind/react/Heading5";
import Button from "@material-tailwind/react/Button";
import "pages/EmployeeCss.css";
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import Carousel from "react-bootstrap/Carousel";
import { deleteTeam } from "services/TeamService";
import { GetTeamById } from "services/TeamService";
import { GetById } from "services/EmployeeService";

const settings = {
  dot: true,
  infinite: true,
  slidesToShow: 4,
  slidesToScroll: 1,
};

export default function Team2(props) {
  const [list, setList] = useState();
  const [teamID, setID] = useState();
  const [description, setDescription] = useState();
  //const [employeeID, setEmployeeID] = useState();

  useEffect(async () => {
    try {
      const response = await getTeam();
      console.log(response.data);
      setList(response.data);
      console.log(response.data.teamID);
      setID(response.data.teamID);
      //setEmployeeID(response.data.employeeID);
    } catch (error) {
      console.log(error);
    }
  }, []);

  const deleteTeams = async (id) => {
    const del = await deleteTeam(id);
  };

  const showDescription = async (id) => {
    console.log(id);
    const showDesc = await GetById(id);
    setDescription(showDesc.data.description);
    console.log(showDesc.data);
  };

  const showEmployees = async (id) => {
    console.log(id);
    const showEmpl = await GetById(id);
    setDescription(showEmpl.data.description);
    console.log(showEmpl.data);
  };

  return (
    <div className="primaryC">
      <div className="primaryD" />
      <div className="header">
        <H3 color="white">Teams</H3>
        <Button color="blue" ripple="dark">
          <a href="Team2Profile">Add</a>
        </Button>
      </div>

      <Slider className="teamA" {...settings}>
        {list &&
          list.map((item, index) => (
            <div className="Schedule">
              <Carousel.Item
                className="teamView"
                key={index}
                value={item.teamID}
                onClick={() => showDescription(item.teamID)}
                //onClick={() => showEmployees(item.employeeID)}
              >
                <Carousel.Caption>
                  <H3 color="white">{item.name}</H3>
                </Carousel.Caption>
                <div className="editDelIcon">
                  <a href={`/Team2Edit/${item.teamID}`}>
                    <i class="far fa-edit"></i>
                  </a>
                  <i
                    type="button"
                    class="fas fa-trash-alt"
                    onClick={() => deleteTeams(item.teamID)}
                  ></i>
                </div>
              </Carousel.Item>
            </div>
          ))}
      </Slider>

      <div className="showDesc">
        <span>{description}</span>
      </div>

      {/* <div className="showEmpl">
        <span>{employeeID}</span>
      </div> */}
    </div>
  );
}
