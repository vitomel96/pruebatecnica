import { Component, ViewChild } from '@angular/core';
import { Persona } from '../../../domain/models/Persona/persona';
import { PersonaService } from '../../../infraestructure/driven-adapter/services/persona/persona.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-persona',
  templateUrl: './persona.component.html',
  styleUrl: './persona.component.css'
})
export class PersonaComponent {
  displayedColumns: string[] = ['cedula', 'nombre', 'apellido', 'actions'];
  personas: any;
  @ViewChild(MatPaginator) paginator: MatPaginator | any;

  constructor(private personaService: PersonaService) {}

  ngOnInit(): void {
    this.loadPersonas();
  }

  loadPersonas() {
    // Llama a tu servicio para obtener la lista de personas
    this.personaService.getAll().subscribe((data: Persona[]) => {

      this.personas = new MatTableDataSource(data);
      this.personas.paginator = this.paginator;
    }
    )
  }

  openNewPersonaDialog() {
    // Lógica para abrir un diálogo para agregar una nueva persona
  }

  openEditPersonaDialog(persona: Persona) {
    // Lógica para abrir un diálogo para editar la persona
  }

  deletePersona(id: string) {
    // Lógica para eliminar la persona
    this.personaService.delete(id).subscribe(() => this.loadPersonas());
  }
}
