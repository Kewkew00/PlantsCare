import { Routes } from '@angular/router';
import { PlantsComponent } from './components/plants/plants.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { NewplantComponent } from './components/newplant/newplant.component';

export const routes: Routes = [
    {
        path: '', component: DashboardComponent
    },

    {
        path: 'plants', component:PlantsComponent
    },

    {
        path:'newplant', component: NewplantComponent
    }
]