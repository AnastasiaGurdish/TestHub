import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CommonModule } from '@angular/common';
import { AngularMaterialModule } from '../angular-material.module';
import { FlexLayoutModule } from "@angular/flex-layout";
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PopupService } from './services/popup.service';
import { ValidationService } from './services/validation.service';
import { AuthenticationService } from './services/authentication.service';
import { AuthenticationGuard } from './guards/authentication.guard';

import { RegistrationComponent } from './components/registration/registration.component';
import { AuthenticationComponent } from './components/authentication/authentication.component';
import { SnackBarService } from './services/snack-bar.service';
import { MatSnackBar } from '@angular/material/snack-bar';

import { CoreRoutingModule } from './core-routing.module';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  imports: [
    SharedModule,
    CommonModule,
    CoreRoutingModule,
    AngularMaterialModule,
    FlexLayoutModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  declarations: [
    RegistrationComponent,
    AuthenticationComponent
  ],
  providers: [
    ValidationService,
    PopupService,
    AuthenticationGuard,
    AuthenticationService,
    SnackBarService,
    MatSnackBar
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class CoreModule { }
