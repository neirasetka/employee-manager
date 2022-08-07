import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createEmployeeTeamRole = (newEmployeeRole) => {
  const url = baseUrl + "EmployeeTeamRole/insertEmployeeTeamRoles";
  return axios.post(url, newEmployeeRole);
};

export const getEmployeeTeamRole = () => {
  const url = baseUrl + "EmployeeTeamRole/getEmployeeTeamRoles";
  return axios.get(url);
};

export const updateEmployeeTeamRole = (id) => {
  const url = baseUrl + `EmployeeTeamRole/updateEmployeeTeamRoles/${id}`;
  return axios.post(url, updateEmployeeTeamRole);
};

export const deleteEmployeeTeamRole = (id) => {
  const url = baseUrl + `EmployeeTeamRole/deleteEmployeeTeamRoles/${id}`;
  return axios.delete(url);
};
