import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from "@angular/flex-layout";
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ValidationService } from './services/validation.service';
import { AuthenticationService } from './services/authentication.service';
import { AuthenticationGuard } from './guards/authentication.guard';

import { RegistrationComponent } from './components/registration/registration.component';
import { AuthenticationComponent } from './components/authentication/authentication.component';

import { CoreRoutingModule } from './core-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { PrimeNgModule} from '../primeng.module';

@NgModule({
  imports: [
    SharedModule,
    CommonModule,
    CoreRoutingModule,
    FlexLayoutModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    PrimeNgModule
  ],
  declarations: [
    RegistrationComponent,
    AuthenticationComponent
  ],
  providers: [
    ValidationService,
    AuthenticationGuard,
    AuthenticationService,    ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class CoreModule { }
