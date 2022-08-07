import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Button from "@material-tailwind/react/Button";
import React, { useEffect, useState } from "react";
import { createTeam, GetById } from "services/TeamService";

export default function Form(props) {
  const [teamID, setID] = useState();
  const [weeklyEngagement, setWeeklyEngagement] = useState();
  const [name, setName] = useState();
  const [status, setStatus] = useState();
  const [pricing, setPricing] = useState();
  const [amount, setAmount] = useState();
  const [projectID, setProjectID] = useState();
  const [isDeleted, setIsDeleted] = useState();
  const [description, setDescription] = useState();
  const [employeesTeamID, setEmployeesTeamID] = useState();

  useEffect(async () => {
    console.log(props.match.params.id);
    const response = await GetById(props.match.params.id);
    console.log(response.data);

    setID(response.data.teamID);
    setWeeklyEngagement(response.data.weeklyEngagement);
    setName(response.data.name);
    setStatus(response.data.status);
    setPricing(response.data.pricing);
    setAmount(response.data.amount);
    setProjectID(response.data.projectID);
    setIsDeleted(response.data.isDeleted);
    setDescription(response.data.description);
    setEmployeesTeamID(response.data.employeesTeamID);
    console.log(response.data.teamID);
  }, [props.match.params.id]);

  function handleIDChange(event) {
    console.log(event);
    setID(event.target.value);
  }

  function handleWeeklyEngagementChange(event) {
    console.log(event);
    setWeeklyEngagement(event.target.value);
  }

  function handleNameChange(event) {
    console.log(event);
    setName(event.target.value);
  }

  function handleStatusChange(event) {
    console.log(event);
    setStatus(event.target.value);
  }

  function handlePricingChange(event) {
    console.log(event);
    setPricing(event.target.value);
  }

  function handleAmountChange(event) {
    console.log(event);
    setAmount(event.target.value);
  }

  function handleProjectIDChange(event) {
    console.log(event);
    setProjectID(event.target.value);
  }

  function handleIsDeletedChange(event) {
    console.log(event);
    setIsDeleted(event.target.value);
  }

  function handleDescriptionChange(event) {
    console.log(event);
    setDescription(event.target.value);
  }

  function handleEmployeesTeamIDChange(event) {
    console.log(event);
    setEmployeesTeamID(event.target.value);
  }

  async function handleSubmit(event) {
    try {
      event.preventDefault();
      const newTeam = {
        teamID: teamID,
        weeklyEngagement: weeklyEngagement,
        name: name,
        status: status,
        pricing: pricing,
        amount: amount,
        projectID: projectID,
        isDeleted: isDeleted,
        description: description,
        endDemployeesTeamIDate: employeesTeamID,
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
                  type="hidden"
                  placeholder="teamID"
                  color="lightBlue"
                  name="teamID"
                  value={teamID}
                  onChange={handleIDChange}
                />
                <Input
                  type="text"
                  placeholder="Weekly engagement"
                  color="lightBlue"
                  name="weeklyEngagement"
                  value={weeklyEngagement}
                  onChange={handleWeeklyEngagementChange}
                />
                <Input
                  type="text"
                  placeholder="Name"
                  color="lightBlue"
                  name="name"
                  value={name}
                  onChange={handleNameChange}
                />
                <Input
                  type="email"
                  placeholder="Status"
                  color="lightBlue"
                  name="status"
                  value={status}
                  onChange={handleStatusChange}
                />
                <Input
                  type="phone"
                  placeholder="Pricing"
                  color="lightBlue"
                  name="pricing"
                  value={pricing}
                  onChange={handlePricingChange}
                />
                <Input
                  type="date"
                  placeholder="Amount"
                  color="lightBlue"
                  name="amount"
                  value={amount}
                  onChange={handleAmountChange}
                />
                <Input
                  type="date"
                  placeholder="ProjectID"
                  color="lightBlue"
                  name="projectID"
                  value={projectID}
                  onChange={handleProjectIDChange}
                />
                <Input
                  type="number"
                  placeholder="Is Deleted"
                  color="lightBlue"
                  name="isDeleted"
                  value={isDeleted}
                  onChange={handleIsDeletedChange}
                />
                <Input
                  type="text"
                  placeholder="Description"
                  color="lightBlue"
                  name="description"
                  value={description}
                  onChange={handleDescriptionChange}
                />
                <Input
                  type="date"
                  placeholder="EmployeesTeamID"
                  color="lightBlue"
                  name="employeesTeamID"
                  value={employeesTeamID}
                  onChange={handleEmployeesTeamIDChange}
                />
              </div>

              {/* <Textarea color="lightBlue" placeholder="Message" /> */}

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
