import { Routes } from '@angular/router';
import { PlantsComponent } from './components/plants/plants.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { NewplantComponent } from './components/newplant/newplant.component';
import { WateringsComponent } from './components/waterings/waterings.component';
import { NewwateringComponent } from './components/newwatering/newwatering.component';

export const routes: Routes = [
    {
        path: '', component: DashboardComponent
    },

    {
        path: 'plants', component:PlantsComponent
    },

    {
        path:'newplant', component: NewplantComponent
    },

    {
        path:'waterings', component: WateringsComponent,
    },

    {
        path:'new', component: NewwateringComponent
    },

   
    
]