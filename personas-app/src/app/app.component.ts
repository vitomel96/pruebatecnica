import { Component } from '@angular/core';
import * as Aos from "aos";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'personas-app';
  ngOnInit(): void {
    Aos.init();
  }
}
