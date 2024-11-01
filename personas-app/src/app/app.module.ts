import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppComponent } from './app.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { PersonaGateway } from './domain/models/Persona/gateway/persona-gateway';
import { PersonaService } from './infraestructure/driven-adapter/services/persona/persona.service';
import { DefaultModule } from './UI/layouts/default/default.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AuthInterceptor } from './domain/interceptor/AuthInterceptor';



@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    DefaultModule,
    HttpClientModule,
    NgbModule,

  ],
  providers: [
    {provide: PersonaGateway, useClass: PersonaService},
    {provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true}
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})


export class AppModule { }
