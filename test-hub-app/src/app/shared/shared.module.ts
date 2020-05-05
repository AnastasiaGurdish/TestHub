import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AngularMaterialModule } from '../angular-material.module';
import { FlexLayoutModule } from "@angular/flex-layout";


@NgModule({
  imports: [
    CommonModule,
    AngularMaterialModule,
    FlexLayoutModule
  ],
  declarations: [],
exports: []
})
export class SharedModule { }
