import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthenticationComponent } from './components/authentication/authentication.component';
import { RegistrationComponent } from './components/registration/registration.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'signin' },
    {path: 'signup', component: RegistrationComponent},
    {path: 'signin', component: AuthenticationComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CoreRoutingModule { }