import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createContactUs = (contactUsMessage) => {
  const url = baseUrl + "ContactUsMessages/insert";
  return axios.post(url, contactUsMessage);
};

export const getContactUs = () => {
  const url = baseUrl + "ContactUsMessages/get";
  return axios.get(url, {});
};

export const updateContactUs = () => {
  const url = baseUrl + `ContactUsMessages/update`;
  return axios.post(url, updateContactUs);
};

export const deleteContactUs = () => {
  const url = baseUrl + `ContactUsMessages/delete`;
  return axios.delete(url, deleteContactUs);
};
