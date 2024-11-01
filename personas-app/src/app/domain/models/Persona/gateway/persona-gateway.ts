import { Observable } from "rxjs";

import { Persona } from "../persona";

export abstract class PersonaGateway {
    currentPersona!: Persona;
    abstract getAll(): Observable<Persona[]>;
    abstract getById(id: string): Observable<Persona>;
    abstract create(Persona: Persona): Observable<Persona>;
    abstract update(id: string, Persona: Persona): Observable<Persona>;
    abstract delete(id: string): Observable<Persona>;
  }
