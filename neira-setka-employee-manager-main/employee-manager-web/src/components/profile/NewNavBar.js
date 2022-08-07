import { useState } from "react";
import { Link } from "react-router-dom";
import Navbar from "@material-tailwind/react/Navbar";
import NavbarContainer from "@material-tailwind/react/NavbarContainer";
import NavbarWrapper from "@material-tailwind/react/NavbarWrapper";
import NavbarBrand from "@material-tailwind/react/NavbarBrand";
import NavbarToggler from "@material-tailwind/react/NavbarToggler";
import NavbarCollapse from "@material-tailwind/react/NavbarCollapse";
import Nav from "@material-tailwind/react/Nav";
import NavLink from "@material-tailwind/react/NavLink";
import Dropdown from "@material-tailwind/react/Dropdown";
// import DropdownItem from "@material-tailwind/react/DropdownItem";
import Icon from "@material-tailwind/react/Icon";
import Button from "@material-tailwind/react/Button";

export default function DefaultNavbar() {
  const [openNavbar, setOpenNavbar] = useState(false);

  return (
    <Navbar color="transparent" navbar>
      <NavbarContainer>
        <NavbarWrapper>
          <a href="" target="" rel="noreferrer">
            <NavbarBrand>TimeKeeper</NavbarBrand>
          </a>
          <NavbarToggler
            onClick={() => setOpenNavbar(!openNavbar)}
            color="white"
          />
        </NavbarWrapper>

        <NavbarCollapse open={openNavbar}>
          <Nav>
            <div className="flex flex-col z-50 lg:flex-row lg:items-center">
              <Dropdown
                color="transparent"
                size="sm"
                buttonType="link"
                buttonText={
                  <div className="py-2.5 font-medium flex items-center">
                    <Icon name="view_carousel" size="2xl" color="white" />
                    <span className="ml-2">Database</span>
                  </div>
                }
                ripple="light"
              ></Dropdown>
              <NavLink href="" target="" rel="noreferrer" ripple="light">
                <Icon name="description" size="2x1" />
                &nbsp;Time
              </NavLink>
              <NavLink href="" target="" rel="noreferrer" ripple="light">
                <Icon name="description" size="2x1" />
                &nbsp;Tracking
              </NavLink>
              <NavLink href="" target="" rel="noreferrer" ripple="light">
                <Icon name="description" size="2x1" />
                &nbsp;Billing
              </NavLink>
              <Dropdown
                color="transparent"
                size="sm"
                buttonType="link"
                buttonText={
                  <div className="py-2.5 font-medium flex items-center">
                    <Icon name="view_carousel" size="2xl" color="white" />
                    <span className="ml-2">Reports</span>
                  </div>
                }
                ripple="light"
              ></Dropdown>
              <NavLink href="" target="" rel="noreferrer" ripple="light">
                <Icon name="description" size="2x1" />
                &nbsp;About
              </NavLink>
              <NavLink
                href="/services"
                target=""
                rel="noreferrer"
                ripple="light"
              >
                <Icon name="apps" size="2xl" />
                &nbsp;Services
              </NavLink>
              <NavLink href="/team" target="" rel="noreferrer" ripple="light">
                <Icon name="view_carousel" size="2xl" />
                &nbsp;Team
              </NavLink>
              <div className="text-white"></div>
              <NavLink
                href="/Contact"
                target=""
                rel="noreferrer"
                ripple="light"
              >
                <Icon family="font-awesome" name="fab fa-github" size="xl" />
                &nbsp;Contact
              </NavLink>
              <NavLink
                href="https://github.com/creativetimofficial/material-tailwind/issues?ref=mtk"
                target=""
                rel="noreferrer"
                ripple="light"
              ></NavLink>
              <a href="/login" target="" rel="noreferrer">
                <Button
                  color="transparent"
                  className="bg-white text-black ml-4"
                  ripple="dark"
                >
                  Logout
                </Button>
              </a>
            </div>
          </Nav>
        </NavbarCollapse>
      </NavbarContainer>
    </Navbar>
  );
}
