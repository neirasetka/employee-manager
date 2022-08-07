import H3 from "@material-tailwind/react/Heading3";
import Paragraph from "@material-tailwind/react/Paragraph";
import Input from "@material-tailwind/react/Input";
import Button from "@material-tailwind/react/Button";
import React, { useState, useEffect } from "react";
import { createEmployee } from "services/EmployeeService";

export default function Form(props) {
  const [firstName, setFirstName] = useState();
  const [lastName, setLastName] = useState();
  const [email, setEmail] = useState();
  const [phoneNumber, setPhoneNumber] = useState();
  const [birthDate, setBirthDate] = useState();
  const [beginDate, setBeginDate] = useState();
  const [status, setStatus] = useState();
  const [jobTitle, setJobTitle] = useState();
  const [endDate, setEndDate] = useState();
  const [contractedSalary, setContractedSalary] = useState();

  useEffect(() => {
    console.log(props);
  }, []);

  function handleFirstNameChange(event) {
    console.log(event);
    setFirstName(event.target.value);
  }

  function handleLastNameChange(event) {
    console.log(event);
    setLastName(event.target.value);
  }

  function handleEmailChange(event) {
    console.log(event);
    setEmail(event.target.value);
  }

  function handlePhoneNumberChange(event) {
    console.log(event);
    setPhoneNumber(event.target.value);
  }

  function handleBirthDateChange(event) {
    console.log(event);
    setBirthDate(event.target.value);
  }

  function handleBeginDateChange(event) {
    console.log(event);
    setBeginDate(event.target.value);
  }

  function handleStatusChange(event) {
    console.log(event);
    setStatus(event.target.value);
  }

  function handleJobTitleChange(event) {
    console.log(event);
    setJobTitle(event.target.value);
  }

  function handleEndDateChange(event) {
    console.log(event);
    setEndDate(event.target.value);
  }

  function handleContractedSalaryChange(event) {
    console.log(event);
    setContractedSalary(event.target.value);
  }

  async function handleSubmit(event) {
    try {
      event.preventDefault();
      const newEmployee = {
        firstName: firstName,
        lastName: lastName,
        email: email,
        phoneNumber: phoneNumber,
        birthDate: new Date(birthDate),
        beginDate: new Date(beginDate),
        status: status,
        jobTitle: jobTitle,
        endDate: new Date(endDate),
        contractedSalary: contractedSalary,
      };
      console.log(newEmployee);
      await createEmployee(newEmployee);
      console.log("Added new employee");
      alert("Added new employee!");
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
              <H3 color="gray">Employee profile</H3>
              <Paragraph color="blueGray"></Paragraph>
            </div>
            <form className="formE" onSubmit={(event) => handleSubmit(event)}>
              <div className="flex flex-wrap gap-8 mt-16 mb-12">
                <Input
                  type="text"
                  placeholder="First name"
                  color="lightBlue"
                  name="firstName"
                  value={firstName}
                  onChange={handleFirstNameChange}
                />
                <Input
                  type="text"
                  placeholder="Last name"
                  color="lightBlue"
                  name="lastName"
                  value={lastName}
                  onChange={handleLastNameChange}
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
                  name="phoneNumber"
                  value={phoneNumber}
                  onChange={handlePhoneNumberChange}
                />
                <Input
                  type="date"
                  placeholder="Birth date"
                  color="lightBlue"
                  name="birthDate"
                  value={birthDate}
                  onChange={handleBirthDateChange}
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
                  type="number"
                  placeholder="Status"
                  color="lightBlue"
                  name="status"
                  value={status}
                  onChange={handleStatusChange}
                />
                <Input
                  type="text"
                  placeholder="Job title"
                  color="lightBlue"
                  name="jobTitle"
                  value={jobTitle}
                  onChange={handleJobTitleChange}
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
                  placeholder="Contracted salary"
                  color="lightBlue"
                  name="contractedSalary"
                  value={contractedSalary}
                  onChange={handleContractedSalaryChange}
                />
              </div>

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
