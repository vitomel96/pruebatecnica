import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultComponent } from './default.component';
import { SharedModule } from "../../shared/shared.module";
import { RouterModule } from '@angular/router';
import { HomeModule } from '../../modules/home/home.module';
import { PersonaModule } from '../../modules/persona/persona.module';



@NgModule({
  declarations: [DefaultComponent],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    HomeModule,
    PersonaModule
],
schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class DefaultModule { }
