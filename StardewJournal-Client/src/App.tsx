import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities ] = useState([]);
  const [villagers, setVillagers] = useState([]);

  //hook useEffect
  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data)
      });
  }, []);
  useEffect(() => {
    axios.get('http://localhost:5000/api/villagers')
      .then(response => {
        setVillagers(response.data)
      });
  }, []);
  return (
    <div>
      <Header as='h2' icon='tree' content='Stardew Valley Handbook'/>
      <h2>Activities</h2>
      <List>
        {activities.map((activity: any) => (
          <List.Item key={activity.id}>{activity.title}</List.Item>
        ))}
      </List>
      <h2>Villagers</h2>
      <List>
        {villagers.map((villager: any) => (
          <List.Item key={villager.id}>{villager.name}</List.Item>
        ))}
      </List>

    </div>
  )
}

export default App
