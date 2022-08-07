import { useEffect, useState } from "react";
import { getProject } from "services/ProjectService";
import React, { Component } from "react";
import H3 from "@material-tailwind/react/Heading5";
import Button from "@material-tailwind/react/Button";
import "pages/EmployeeCss.css";

export default function Project(props) {
  const [list, setList] = useState();
  const [projectID, setID] = useState();

  useEffect(async () => {
    try {
      const response = await getProject();
      console.log(response);
      setList(response.data);
      console.log(response.data.projectID);
      setID(response.data.projectID);
    } catch (error) {
      console.log(error);
    }
  }, []);

  return (
    <div className="primaryC">
      <div className="primaryD" />
      <div className="header">
        <H3 color="white">Projects</H3>
        <Button color="blue" ripple="dark">
          <a href="ProjectProfile">Add</a>
        </Button>
      </div>
      <div className="tableData">
        <table className="table">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Project name</th>
              <th scope="col">Customer name</th>
              <th scope="col">Team name</th>
              <th scope="col">Status</th>
              <th scope="col">Actions</th>
            </tr>
          </thead>
          <tbody>
            {list &&
              list.map((item) => (
                <tr key={item.projectID}>
                  <td>{item.projectID}</td>
                  <td>{item.name}</td>
                  <td>{item.clientName}</td>
                  <td>{item.teamName}</td>
                  <td>{item.status}</td>
                  <td>
                    <a href={`/ProjectEdit/${item.projectID}`}>Edit</a>
                    <a href={`/ProjectView/${item.projectID}`}>View</a>
                  </td>
                </tr>
              ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
