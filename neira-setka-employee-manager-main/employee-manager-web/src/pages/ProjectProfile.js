import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Button from "@material-tailwind/react/Button";
import React, { useState, useEffect } from "react";
import { createProject } from "services/ProjectService";
import { getClient } from "services/ClientService";
import { getTeam } from "services/TeamService";

export default function Form(props) {
  const [projectID, setID] = useState();
  const [name, setName] = useState();
  const [shortDescription, setShortDescription] = useState();
  const [beginDate, setBeginDate] = useState();
  const [endDate, setEndDate] = useState();
  const [status, setStatus] = useState();
  const [clientList, setClientList] = useState();
  const [teamList, setTeamList] = useState();
  const [pricingValue, setPricingValue] = useState();
  const [clientID, setClientID] = useState();
  const [teamID, setTeamID] = useState();

  useEffect(async () => {
    const customers = await getClient();
    setClientList(customers.data);
    console.log(customers);
  }, []);

  useEffect(async () => {
    const teams = await getTeam();
    setTeamList(teams.data);
    console.log(teams);
  }, []);

  function handleIDChange(event) {
    console.log(event);
    setID(event.target.value);
  }

  const handleNameChange = (event) => {
    console.log(event);
    setName(event.target.value);
  };

  const handleShortDescriptionChange = (event) => {
    console.log(event);
    setShortDescription(event.target.value);
  };

  const handleBeginDateChange = (event) => {
    console.log(event);
    setBeginDate(event.target.value);
  };

  const handleEndDateChange = (event) => {
    console.log(event);
    setEndDate(event.target.value);
  };

  const handleStatusChange = (event) => {
    console.log(event);
    setStatus(event.target.value);
  };

  const handleClientChange = (event) => {
    console.log(event);
    setClientList(event.target.value);
  };

  const handleTeamChange = (event) => {
    console.log(event);
    setTeamList(event.target.value);
  };

  const handlePricingValueChange = (event) => {
    console.log(event);
    setPricingValue(event.target.value);
  };

  async function handleSubmit(event) {
    try {
      event.preventDefault();
      const newProject = {
        projectID: projectID,
        name: name,
        shortDescription: shortDescription,
        beginDate: new Date(beginDate),
        endDate: new Date(endDate),
        status: status,
        // clientList: clientList,
        // teamList: teamList,
        pricingValue: pricingValue,
        clientID: clientID,
        teamID: teamID,
      };
      console.log(newProject);
      await createProject(newProject);
      console.log("Added new project");
      alert("Added new project!");
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
              <H3 color="gray">Project profile</H3>

              <Paragraph color="blueGray"></Paragraph>
            </div>
            <form className="formE" onSubmit={(event) => handleSubmit(event)}>
              <div className="flex flex-wrap gap-8 mt-16 mb-12">
                <Input
                  type="hidden"
                  placeholder="ProjectID"
                  color="lightBlue"
                  name="projectID"
                  value={projectID}
                  onChange={handleIDChange}
                />
                <Input
                  type="text"
                  placeholder="Project name"
                  color="lightBlue"
                  name="name"
                  value={name}
                  onChange={handleNameChange}
                />
                <Input
                  type="text"
                  placeholder="Short description"
                  color="lightBlue"
                  name="shortDescription"
                  value={shortDescription}
                  onChange={handleShortDescriptionChange}
                />
                <Input
                  type="date"
                  placeholder="Begin date"
                  color="lightBlue"
                  name="beginDate"
                  value={beginDate}
                  onChange={handleBeginDateChange}
                />
                <Input
                  type="date"
                  placeholder="End date"
                  color="lightBlue"
                  name="endDate"
                  value={endDate}
                  onChange={handleEndDateChange}
                />
              </div>

              <label>Customer: </label>
              <select className="inputs" onChange={handleClientChange}>
                {clientList &&
                  clientList.map((item) => (
                    <option key={item.clientID} value={item.clientID}>
                      {item.businessName}
                    </option>
                  ))}
              </select>

              <label>Team: </label>
              <select className="inputs" onChange={handleTeamChange}>
                {teamList &&
                  teamList.map((item) => (
                    <option key={item.teamID} value={item.teamID}>
                      {item.name}
                    </option>
                  ))}
              </select>

              <label>Pricing: </label>
              <select
                className="inputs"
                type="text"
                placeholder="Pricing"
                value={pricingValue}
                name="pricingValue"
                onChange={handlePricingValueChange}
              ></select>

              <label>Status: </label>
              <select
                className="inputs"
                type="text"
                placeholder="Status"
                value={status}
                name="status"
                onChange={handleStatusChange}
              ></select>

              {/* <Textarea color="lightBlue" placeholder="Message" /> */}

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
