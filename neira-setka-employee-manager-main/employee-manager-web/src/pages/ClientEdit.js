import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Textarea from "@material-tailwind/react/Textarea";
import Button from "@material-tailwind/react/Button";
import React, { useEffect, useState } from "react";
import { createClient, GetById } from "services/ClientService";

export default function Form(props) {
  const [clientID, setID] = useState();
  const [businessName, setBusinessName] = useState();
  const [contactName, setContactName] = useState();
  const [email, setEmail] = useState();
  const [Phone, setPhone] = useState();
  const [homeAddress, setHomeAddress] = useState();
  const [zipCity, setZipCity] = useState();
  const [status, setStatus] = useState();

  useEffect(async () => {
    console.log(props.match.params.id);
    const response = await GetById(props.match.params.id);
    console.log(response.data);

    setID(response.data.clientID);
    setBusinessName(response.data.businessName);
    setContactName(response.data.contactName);
    setEmail(response.data.email);
    setPhone(response.data.phoneNumber);
    setHomeAddress(response.data.homeAddress);
    setZipCity(response.data.zipCity);
    setStatus(response.data.status);
    console.log(response.data.clientID);
  }, [props.match.params.id]);

  function handleIDChange(event) {
    console.log(event);
    setID(event.target.value);
  }

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
        clientID: clientID,
        businessName: businessName,
        contactName: contactName,
        email: email,
        Phone: Phone,
        homeAddress: homeAddress,
        zipCity: zipCity,
        status: status,
      };
      console.log(newClient);
      await createClient(newClient);
      console.log("Added new client");
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
              <H3 color="gray">Client profile</H3>
              <Paragraph color="blueGray"></Paragraph>
            </div>
            <form className="formE" onSubmit={(event) => handleSubmit(event)}>
              <div className="flex flex-wrap gap-8 mt-16 mb-12">
                <Input
                  type="hidden"
                  placeholder="clientID"
                  color="lightBlue"
                  name="clientID"
                  value={clientID}
                  onChange={handleIDChange}
                />
                <Input
                  type="text"
                  placeholder="businessName"
                  color="lightBlue"
                  name="businessName"
                  value={businessName}
                  onChange={handleBusinessNameChange}
                />
                <Input
                  type="text"
                  placeholder="contactName"
                  color="lightBlue"
                  name="contactName"
                  value={contactName}
                  onChange={handleContactNameChange}
                />
                <Input
                  type="email"
                  placeholder="email"
                  color="lightBlue"
                  name="email"
                  value={email}
                  onChange={handleEmailChange}
                />
                <Input
                  type="phone"
                  placeholder="phone"
                  color="lightBlue"
                  name="phone"
                  value={Phone}
                  onChange={handlePhoneChange}
                />
                <Input
                  type="text"
                  placeholder="homeAddress"
                  color="lightBlue"
                  name="homeAddress"
                  value={homeAddress}
                  onChange={handleHomeAddressChange}
                />
                <Input
                  type="text"
                  placeholder="zipCity"
                  color="lightBlue"
                  name="zipCity"
                  value={zipCity}
                  onChange={handleZipCityChange}
                />
                <Input
                  type="text"
                  placeholder="Status"
                  color="lightBlue"
                  name="Status"
                  value={status}
                  onChange={handleStatusChange}
                />
              </div>

              <Textarea color="lightBlue" placeholder="Message" />

              <div className="flex justify-center mt-10">
                <Button type="submit" color="lightBlue" ripple="light">
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
