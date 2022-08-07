import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createProject = (newProject) => {
  const url = baseUrl + "Project/insertProjects";
  return axios.post(url, newProject);
};

export const getProject = () => {
  const url = baseUrl + "Project/getProjects";
  return axios.get(url);
};

export const updateProject = (id) => {
  const url = baseUrl + `Project/updateProjects/${id}`;
  return axios.post(url);
};

export const deleteProject = (id) => {
  const url = baseUrl + `Project/deleteProjects/${id}`;
  return axios.delete(url);
};

export const GetById = (id) => {
  const url = baseUrl + `Project/getProjectById/${id}`;
  return axios.get(url);
};
