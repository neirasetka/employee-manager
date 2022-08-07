import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createTeam = (newTeam) => {
  const url = baseUrl + "Team/insertTeams";
  return axios.post(url, newTeam);
};

export const getTeam = () => {
  const url = baseUrl + "Team/getTeams";
  return axios.get(url);
};

export const updateTeam = (id) => {
  const url = baseUrl + `Team/updateTeams/${id}`;
  return axios.post(url, updateTeam);
};

export const deleteTeam = (id) => {
  const url = baseUrl + `Team/deleteTeams/${id}`;
  return axios.delete(url);
};

export const GetById = (id) => {
  const url = baseUrl + `Team/getTeamById/${id}`;
  return axios.get(url);
};
