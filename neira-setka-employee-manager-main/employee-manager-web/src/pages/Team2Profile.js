import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Button from "@material-tailwind/react/Button";
import React, { useState, useEffect } from "react";
import { createTeam } from "services/TeamService";
//import EmployeeAndRoleView from "pages/EmployeeAndRoleView";

export default function Form(props) {
  const [teamID, setTeamID] = useState();
  const [weeklyEngagement, setWeeklyEngagement] = useState();
  const [name, setName] = useState();
  const [status, setStatus] = useState();
  const [pricing, setPricing] = useState();
  const [amount, setAmount] = useState();
  const [projectID, setProjectID] = useState();
  const [isDeleted, setIsDeleted] = useState();
  const [description, setDescription] = useState();
  const [employeesTeamID, setEmployeesTeamID] = useState();

  useEffect(() => {
    console.log(props);
  }, []);

  // function handleTeamIDChange(event) {
  //   console.log(event);
  //   setTeamID(event.target.value);
  // }

  // function handleWeeklyEngagementChange(event) {
  //   console.log(event);
  //   setWeeklyEngagement(event.target.value);
  // }

  function handleNameChange(event) {
    console.log(event);
    setName(event.target.value);
  }

  // function handleStatusChange(event) {
  //   console.log(event);
  //   setStatus(event.target.value);
  // }

  // function handlePricingChange(event) {
  //   console.log(event);
  //   setPricing(event.target.value);
  // }

  // function handleAmountChange(event) {
  //   console.log(event);
  //   setAmount(event.target.value);
  // }

  // function handleProjectIDChange(event) {
  //   console.log(event);
  //   setProjectID(event.target.value);
  // }

  // function handleIsDeletedChange(event) {
  //   console.log(event);
  //   setIsDeleted(event.target.value);
  // }

  function handleDescriptionChange(event) {
    console.log(event);
    setDescription(event.target.value);
  }

  // function handleEmployeesTeamIDChange(event) {
  //   console.log(event);
  //   setEmployeesTeamID(event.target.value);
  // }

  async function handleSubmit(event) {
    try {
      event.preventDefault();
      const newTeam = {
        weeklyEngagement: weeklyEngagement,
        name: name,
        status: status,
        pricing: pricing,
        amount: amount,
        projectID: projectID,
        isDeleted: isDeleted,
        description: description,
        employeesTeamID: employeesTeamID,
      };
      console.log(newTeam);
      await createTeam(newTeam);
      console.log("Added new team");
      alert("Added new team!");
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
              <H3 color="gray">Team profile</H3>
              <Paragraph color="blueGray"></Paragraph>
            </div>
            <form className="formE" onSubmit={(event) => handleSubmit(event)}>
              <div className="flex flex-wrap gap-8 mt-16 mb-12">
                <Input
                  type="text"
                  placeholder="Team name"
                  color="lightBlue"
                  name="name"
                  value={name}
                  onChange={handleNameChange}
                />
                <Input
                  type="text"
                  placeholder="Description"
                  color="lightBlue"
                  name="description"
                  value={description}
                  onChange={handleDescriptionChange}
                />
              </div>

              {/* <Textarea color="lightBlue" placeholder="Short description" /> */}

              <div className="flex justify-center mt-10">
                <a href="employeeAndRoleView">
                  <Button type="submit" color="lightBlue" ripple="light">
                    Update
                  </Button>
                </a>
                <a href="/team2">
                  <Button type="button" color="lightBlue" ripple="light">
                    Close
                  </Button>
                </a>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  );
}
