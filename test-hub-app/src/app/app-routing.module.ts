import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './modules/admin/components/admin/admin.component';

import { AuthenticationGuard } from './core/guards/authentication.guard';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'auth' },
  { path: 'auth', loadChildren: './core/core.module#CoreModule' },
   { path: 'profile', canActivate: [AuthenticationGuard], component: AdminComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { enableTracing: true })],
  exports: [RouterModule],
})

export class AppRoutingModule { }
