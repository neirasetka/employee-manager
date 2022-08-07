import { useEffect, useState } from "react";
import { getEmployee } from "services/EmployeeService";
import React, { Component } from "react";
import H3 from "@material-tailwind/react/Heading5";
import Button from "@material-tailwind/react/Button";
import "pages/EmployeeCss.css";

export default function Employee(props) {
  const [list, setList] = useState();
  const [employeeID, setID] = useState();

  useEffect(async () => {
    try {
      const response = await getEmployee();
      console.log(response);
      setList(response.data);
      console.log(response.data.employeeID);
      setID(response.data.employeeID);
    } catch (error) {
      console.log(error);
    }
  }, []);

  return (
    <div className="primaryC">
      <div className="primaryD" />
      <div className="header">
        <H3 color="white">Employees</H3>
        <Button color="blue" ripple="dark">
          <a href="EmployeeProfile">Add</a>
        </Button>
      </div>
      <div className="tableData">
        <table className="table">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">First name</th>
              <th scope="col">Last name</th>
              <th scope="col">Age</th>
              <th scope="col">Email</th>
              <th scope="col">Phone</th>
              <th scope="col">Action</th>
            </tr>
          </thead>
          <tbody>
            {list &&
              list.map((item) => (
                <tr key={item.employeeID}>
                  <td>{item.employeeID}</td>
                  <td>{item.firstName}</td>
                  <td>{item.lastName}</td>
                  <td>{item.age}</td>
                  <td>{item.email}</td>
                  <td>{item.phone}</td>
                  <td>
                    <a href={`/EmployeeEdit/${item.employeeID}`}>Edit</a>
                    <a href={`/EmployeeView/${item.employeeID}`}>View</a>
                  </td>
                </tr>
              ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
