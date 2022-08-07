import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createTeamRoles = () => {
  const url = baseUrl + "TeamRoles/insertTeamRoles";
  return axios.post(url, createTeamRoles);
};

export const getTeamRoles = () => {
  const url = baseUrl + "TeamRoles/getTeamRoles";
  return axios.get(url);
};

export const updateTeamRoles = (id) => {
  const url = baseUrl + `TeamRoles/updateTeamRoles/${id}`;
  return axios.post(url);
};

export const deleteTeamRoles = (id) => {
  const url = baseUrl + `TeamRoles/deleteTeamRoles/${id}`;
  return axios.delete(url);
};
