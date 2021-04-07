import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';

const materialModules = [
  MatTabsModule
];

@NgModule({
  imports: [
    CommonModule,
    MatTabsModule
  ],
  exports: [
    MatTabsModule
  ]
})
export class AngularMaterialModule { }
