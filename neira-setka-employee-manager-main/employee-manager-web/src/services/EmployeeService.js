import axios from "axios";

const baseUrl = "http://localhost:5000/api/";

export const createEmployee = (newEmployee) => {
  const url = baseUrl + "Employee/insertEmployees";
  return axios.post(url, newEmployee);
};

export const getEmployee = () => {
  console.log("1234");
  const url = baseUrl + "Employee/getEmployees";
  return axios.get(url);
};

export const updateEmployee = (id) => {
  const url = baseUrl + `Employee/updateEmployees/${id}`;
  return axios.put(url, updateEmployee);
};

export const deleteEmployee = (id) => {
  const url = baseUrl + `Employee/deleteEmployees/${id}`;
  return axios.delete(url);
};

export const GetById = (id) => {
  const url = baseUrl + `Employee/GetEmployeeById/${id}`;
  return axios.get(url);
};
