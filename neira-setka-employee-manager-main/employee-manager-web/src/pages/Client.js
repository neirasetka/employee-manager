import { useEffect, useState } from "react";
import { getClient } from "services/ClientService";
import React, { Component } from "react";
import H3 from "@material-tailwind/react/Heading5";
import Button from "@material-tailwind/react/Button";
import "pages/EmployeeCss.css";

export default function Client(props) {
  const [list, setList] = useState();
  const [clientID, setID] = useState();
  useEffect(async () => {
    try {
      const response = await getClient();
      console.log(response);
      setList(response.data);
      console.log(response.data.clientID);
      setID(response.data.clientID);
    } catch (error) {
      console.log(error);
    }
  }, []);

  return (
    <div className="primaryC">
      <div className="primaryD" />
      <div className="header">
        <H3 color="white">Clients</H3>
        <Button color="blue" ripple="dark">
          <a href="ClientProfile">Add</a>
        </Button>
      </div>
      <div className="tableData">
        <table className="table">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Business name</th>
              <th scope="col">Contact name</th>
              <th scope="col">Email</th>
              <th scope="col">Status</th>
              <th scope="col">Actions</th>
            </tr>
          </thead>
          <tbody>
            {list &&
              list.map((item) => (
                <tr key={item.clientID}>
                  <td>{item.clientID}</td>
                  <td>{item.businessName}</td>
                  <td>{item.contactName}</td>
                  <td>{item.email}</td>
                  <td>{item.status}</td>
                  <td>
                    <a href={`/ClientEdit/${item.clientID}`}>Edit</a>
                    <a href={`/ClientView/${item.clientID}`}>View</a>
                  </td>
                </tr>
              ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
