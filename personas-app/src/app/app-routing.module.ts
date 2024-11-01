import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './UI/modules/home/home.component';
import { DefaultComponent } from './UI/layouts/default/default.component';
import { NgModule } from '@angular/core';
import { PersonaComponent } from './UI/modules/persona/persona.component';

const routes: Routes = [
  {
    path: "",
    component: DefaultComponent,
    children: [
    {
      path: "",
      component: HomeComponent,
    },
    {
      path: "personas",
      component: PersonaComponent,
    },
  ]
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes,{scrollPositionRestoration: 'enabled'})],
  exports: [RouterModule],
})
export class AppRoutingModule {}
