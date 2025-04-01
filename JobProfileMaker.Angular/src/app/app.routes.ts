import { Routes } from '@angular/router';
import { CandidateFormComponent } from './candidate-form/candidate-form.component';
import { ProfilePageComponent } from './profile-page/profile-page.component';
export const routes: Routes = [
    { path:'', redirectTo: '/candidate-form' , pathMatch : 'full'},
    { path: 'candidate-form', component: CandidateFormComponent},
    { path: 'profile', component: ProfilePageComponent},
    { path: '**' , redirectTo: '/candidate-form'}
];
