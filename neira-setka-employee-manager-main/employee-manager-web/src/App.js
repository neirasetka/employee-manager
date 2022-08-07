import React from "react";
import { Switch, Route, Redirect } from "react-router-dom";
import Landing from "pages/Landing";
import Profile from "pages/Profile";
import Login from "pages/Login";
import Register from "pages/Register";
import Contact from "pages/Contact";
import Services from "pages/Services";
import Team from "pages/Team";
import Employee from "pages/Employee";
import EmployeeProfile from "pages/EmployeeProfile";
import EmployeeEdit from "pages/EmployeeEdit";
import EmployeeView from "pages/EmployeeView";
import Client from "pages/Client";
import ClientProfile from "pages/ClientProfile";
import ClientEdit from "pages/ClientEdit";
import ClientView from "pages/ClientView";
import Project from "pages/Project";
import ProjectProfile from "pages/ProjectProfile";
import ProjectEdit from "pages/ProjectEdit";
import ProjectView from "pages/ProjectView";
import Team2 from "pages/Team2";
import Team2Profile from "pages/Team2Profile";
import Team2Edit from "pages/Team2Edit";

// Font Awesome Style Sheet
import "@fortawesome/fontawesome-free/css/all.min.css";

// Tailwind CSS Style Sheet
import "./assets/styles/tailwind.css";

function App() {
  return (
    <Switch>
      <Route exact path="/" component={Landing} />
      <Route exact path="/profile" component={Profile} />
      <Route exact path="/login" component={Login} />
      <Route exact path="/register" component={Register} />
      <Route exact path="/contact" component={Contact} />
      <Route exact path="/services" component={Services} />
      <Route exact path="/team" component={Team} />
      <Route exact path="/employees" component={Employee} />
      <Route exact path="/EmployeeProfile" component={EmployeeProfile} />
      <Route exact path="/clients" component={Client} />
      <Route exact path="/ClientProfile" component={ClientProfile} />
      <Route exact path="/projects" component={Project} />
      <Route exact path="/ProjectProfile" component={ProjectProfile} />
      <Route exact path="/EmployeeEdit/:id" component={EmployeeEdit} />
      <Route exact path="/EmployeeView/:id" component={EmployeeView} />
      <Route exact path="/ClientEdit/:id" component={ClientEdit} />
      <Route exact path="/ClientView/:id" component={ClientView} />
      <Route exact path="/ProjectEdit/:id" component={ProjectEdit} />
      <Route exact path="/ProjectView/:id" component={ProjectView} />
      <Route exact path="/team2" component={Team2} />
      <Route exact path="/Team2Profile" component={Team2Profile} />
      <Route exact path="/Team2Edit/:id" component={Team2Edit} />

      <Redirect from="*" to="/" />
    </Switch>
  );
}

export default App;
