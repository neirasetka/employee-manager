import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Button from "@material-tailwind/react/Button";
import React, { useEffect, useState } from "react";
import { createProject, GetById } from "services/ProjectService";
import { getTeam } from "services/TeamService";
import { getClient } from "services/ClientService";

export default function Form(props) {
  const [projectID, setID] = useState();
  const [name, setName] = useState();
  const [shortDescription, setShortDescription] = useState();
  const [beginDate, setBeginDate] = useState();
  const [endDate, setEndDate] = useState();
  const [status, setStatus] = useState();
  const [clientList, setClientList] = useState([]);
  const [teamList, setTeamList] = useState();
  const [pricingValue, setPricingValue] = useState();
  const [clientID, setClientID] = useState();
  const [teamID, setTeamID] = useState();

  useEffect(async () => {
    console.log(props.match.params.id);
    const response = await GetById(props.match.params.id);
    console.log(response.data);

    setID(response.data.projectID);
    setName(response.data.name);
    setShortDescription(response.data.shortDescription);
    setBeginDate(response.data.beginDate);
    setEndDate(response.data.endDate);
    setStatus(response.data.status);
    setPricingValue(response.data.pricingValue);
    setClientID(response.data.clientID);
    setTeamID(response.data.teamID);
    console.log(response.data.projectID);
  }, []);

  useEffect(async () => {
    const teams = await getTeam();
    setTeamList(teams.data);
    console.log(teams.data);
    const clients = await getClient();
    setClientList(clients.data);
    console.log(clients.data);
  }, []);

  function handleIDChange(event) {
    console.log(event);
    setID(event.target.value);
  }

  function handleNameChange(event) {
    console.log(event);
    setName(event.target.value);
  }

  function handleShortDescriptionChange(event) {
    console.log(event);
    setShortDescription(event.target.value);
  }

  function handleBeginDateChange(event) {
    console.log(event);
    setBeginDate(event.target.value);
  }

  function handleEndDateChange(event) {
    console.log(event);
    setEndDate(event.target.value);
  }

  function handleStatusChange(event) {
    console.log(event);
    setStatus(event.target.value);
  }

  function handleClientChange(event) {
    console.log(event);
    // setClientList(event.target.value);
  }

  function handleTeamChange(event) {
    console.log(event);
    //setTeamList(event.target.value);
  }

  function handlePricingValueChange(event) {
    console.log(event);
    setPricingValue(event.target.value);
  }

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
                <Input
                  type="text"
                  placeholder="Pricing"
                  value={pricingValue}
                  name="pricingValue"
                  onChange={handlePricingValueChange}
                />
                <Input
                  type="text"
                  placeholder="Status"
                  value={status}
                  name="status"
                  onChange={handleStatusChange}
                />
              </div>

              <label>Customer: </label>
              <select className="inputs" onChange={handleClientChange}>
                {clientList &&
                  clientList.map((item) => {
                    if (item.clientID === clientID) {
                      return (
                        <option
                          key={item.clientID}
                          value={item.clientID}
                          selected
                        >
                          {item.businessName}
                        </option>
                      );
                    } else {
                      return (
                        <option key={item.clientID} value={item.clientID}>
                          {item.businessName}
                        </option>
                      );
                    }
                  })}
              </select>

              <label>Team: </label>
              <select className="inputs" onChange={handleTeamChange}>
                {teamList &&
                  teamList.map((item) => {
                    if (item.teamID === teamID) {
                      return (
                        <option key={item.teamID} value={item.teamID} selected>
                          {item.name}
                        </option>
                      );
                    } else {
                      return (
                        <option key={item.teamID} value={item.teamID}>
                          {item.name}
                        </option>
                      );
                    }
                  })}
              </select>

              <div className="buttons">
                <Button type="submit" color="lightBlue" ripple="light">
                  Update
                </Button>
                <Button type="button" color="lightBlue" ripple="light">
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
