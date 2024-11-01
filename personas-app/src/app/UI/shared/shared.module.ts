import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [HeaderComponent, FooterComponent],
  imports: [
    CommonModule,
    RouterModule,
  ],
  exports: [
    HeaderComponent, FooterComponent
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class SharedModule { }