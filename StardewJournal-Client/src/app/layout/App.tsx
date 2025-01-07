import { Fragment, useEffect, useState } from 'react'
import './styles.css'
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import { Villager } from '../models/villager';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivitiesDashboard';

function App() {
  const [activities, setActivities ] = useState<Activity[]>([]);
  const [villagers, setVillagers] = useState<Villager[]>([]);

  //hook useEffect
  useEffect(() => {
    axios.get<Activity[]>('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data)
      });
  }, []);

  useEffect(() => {
    axios.get<Villager[]>('http://localhost:5000/api/villagers')
      .then(response => {
        setVillagers(response.data)
      });
  }, []);

  return (
    <Fragment>
      <NavBar />

      <Container style={{marginTop: '7em'}}>
        <ActivityDashboard activities={activities} />
      
      </Container>
    </Fragment>
  );
}

export default App
