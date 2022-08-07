import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Textarea from "@material-tailwind/react/Textarea";
import Button from "@material-tailwind/react/Button";
import React, { useState, useEffect } from "react";
import { createClient } from "services/ClientService";

export default function Form(props) {
  const [businessName, setBusinessName] = useState();
  const [contactName, setContactName] = useState();
  const [email, setEmail] = useState();
  const [Phone, setPhone] = useState();
  const [homeAddress, setHomeAddress] = useState();
  const [zipCity, setZipCity] = useState();
  const [status, setStatus] = useState();

  useEffect((props) => {
    console.log(props);
  }, []);

  function handleBusinessNameChange(event) {
    console.log(event);
    setBusinessName(event.target.value);
  }

  function handleContactNameChange(event) {
    console.log(event);
    setContactName(event.target.value);
  }

  function handleEmailChange(event) {
    console.log(event);
    setEmail(event.target.value);
  }

  function handlePhoneChange(event) {
    console.log(event);
    setPhone(event.target.value);
  }

  function handleHomeAddressChange(event) {
    console.log(event);
    setHomeAddress(event.target.value);
  }

  function handleZipCityChange(event) {
    console.log(event);
    setZipCity(event.target.value);
  }

  function handleStatusChange(event) {
    console.log(event);
    setStatus(event.target.value);
  }

  async function handleSubmit(event) {
    try {
      event.preventDefault();
      const newClient = {
        businessName: businessName,
        contactName: contactName,
        email: email,
        status: status,
        Phone: Phone,
        homeAddress: homeAddress,
        zipCity: zipCity,
        status: status,
      };
      console.log(newClient);
      await createClient(newClient);
      alert("Added new client!");
    } catch (error) {
      console.log(error);
    }
  }

  return (
    <div className="flex flex-wrap justify-center mt-24 ">
      <div className="w-full lg:w-8/12 px-4">
        <div className="relative flex flex-col min-w-0 break-words w-full mb-6">
          <div className="flex-auto p-5 lg:p-10">
            <div className="w-full text-center">
              <H3 color="gray">Customer profile</H3>

              <Paragraph color="blueGray"></Paragraph>
            </div>
            <form className="formE" onSubmit={(event) => handleSubmit(event)}>
              <div className="flex flex-wrap gap-8 mt-16 mb-12">
                <Input
                  type="text"
                  placeholder="Business name"
                  color="lightBlue"
                  name="businessName"
                  value={businessName}
                  onChange={handleBusinessNameChange}
                />
                <Input
                  type="text"
                  placeholder="Contact name"
                  color="lightBlue"
                  name="contactName"
                  value={contactName}
                  onChange={handleContactNameChange}
                />
                <Input
                  type="email"
                  placeholder="Email"
                  color="lightBlue"
                  name="email"
                  value={email}
                  onChange={handleEmailChange}
                />
                <Input
                  type="phone"
                  placeholder="Phone number"
                  color="lightBlue"
                  name="phone"
                  value={Phone}
                  onChange={handlePhoneChange}
                />
                <Input
                  type="text"
                  placeholder="Home address"
                  color="lightBlue"
                  name="homeAddress"
                  value={homeAddress}
                  onChange={handleHomeAddressChange}
                />
                <Input
                  type="text"
                  placeholder="Zip city"
                  color="lightBlue"
                  name="zipCity"
                  value={zipCity}
                  onChange={handleZipCityChange}
                />
                <Input
                  type="text"
                  placeholder="Status"
                  color="lightBlue"
                  name="status"
                  value={status}
                  onChange={handleStatusChange}
                />
              </div>

              <div className="flex justify-center mt-10">
                <Button color="lightBlue" ripple="light">
                  Update
                </Button>
                <Button color="lightBlue" ripple="light">
                  Close
                </Button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  );
}
