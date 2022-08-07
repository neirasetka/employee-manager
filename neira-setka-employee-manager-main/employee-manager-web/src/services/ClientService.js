import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createClient = (newClient) => {
  const url = baseUrl + "Client/insertClients";
  return axios.post(url, newClient);
};

export const getClient = () => {
  const url = baseUrl + "Client/getClients";
  return axios.get(url);
};

export const updateClient = (id) => {
  const url = baseUrl + `Client/updateClients/${id}`;
  return axios.post(url);
};

export const deleteClient = (id) => {
  const url = baseUrl + `Client/deleteByIdClients/${id}`;
  return axios.delete(url);
};

export const GetById = (id) => {
  const url = baseUrl + `Client/GetClientById/${id}`;
  return axios.get(url);
};
