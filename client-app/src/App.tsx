import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
const [activities,setActivies]=useState([]);
useEffect(()=>{
axios.get('http://localhost:5000/api/activities').then(Response=>{
  console.log(Response);
  setActivies(Response.data);

})
},[])

  return (
    <div>
      <Header as ='H2' icon="users" content="Reactivities"></Header>
      <List>{activities.map((activity:any)=>(
        <List.Item key={activity.id}>{activity.title}</List.Item >
      ))}</List>
     
    </div>
  );
}

export default App;
