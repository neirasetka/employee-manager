import { useState } from "react";
import Navbar from "@material-tailwind/react/Navbar";
import NavbarContainer from "@material-tailwind/react/NavbarContainer";
import NavbarWrapper from "@material-tailwind/react/NavbarWrapper";
import NavbarBrand from "@material-tailwind/react/NavbarBrand";
import NavbarToggler from "@material-tailwind/react/NavbarToggler";
import NavbarCollapse from "@material-tailwind/react/NavbarCollapse";
import Nav from "@material-tailwind/react/Nav";
import NavLink from "@material-tailwind/react/NavLink";
import Dropdown from "@material-tailwind/react/Dropdown";
import DropdownItem from "@material-tailwind/react/DropdownItem";
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
                href="/employees"
                target=""
                rel="noreferrer"
                ripple="light"
              >
                <Icon name="description" size="2x1" />
                &nbsp;Employee
              </NavLink>

              <NavLink
                href="/clients"
                target=""
                rel="noreferrer"
                ripple="light"
              >
                <Icon name="description" size="2x1" />
                &nbsp;Client
              </NavLink>

              <NavLink
                href="/projects"
                target=""
                rel="noreferrer"
                ripple="light"
              >
                <Icon name="description" size="2x1" />
                &nbsp;Project
              </NavLink>
              <NavLink href="/team2" target="" rel="noreferrer" ripple="light">
                <Icon name="description" size="2x1" />
                &nbsp;Team2
              </NavLink>
              <a href="/login" target="" rel="noreferrer">
                <Button
                  color="transparent"
                  className="bg-white text-black ml-4"
                  ripple="dark"
                >
                  Login
                </Button>
              </a>
            </div>
          </Nav>
        </NavbarCollapse>
      </NavbarContainer>
    </Navbar>
  );
}
