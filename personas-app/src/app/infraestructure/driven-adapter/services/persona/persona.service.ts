import { Injectable } from "@angular/core";
import { PersonaGateway } from "../../../../domain/models/Persona/gateway/persona-gateway";
import { Observable } from "rxjs";
import { Persona } from "../../../../domain/models/Persona/persona";
import { GenericService } from "../../../helpers/generic.service";
import { environment } from "../../../../../environments/environment";

@Injectable({
  providedIn: "root",
})
export class PersonaService extends PersonaGateway {
  private _url = environment.backendURL;
  constructor(private genericService: GenericService) {
    super();
  }
  override getAll(): Observable<Persona[]> {
    return this.genericService.get<any>(this._url, `persona` )
  }
  override getById(id: string): Observable<Persona> {
    return this.genericService.get<any>(this._url, `persona/${id}` )
  }
  override create(Persona: Persona): Observable<Persona> {
    return this.genericService.post<Persona>(this._url, "persona", Persona);
  }
  override update(id: string, Persona: Persona): Observable<Persona> {
    return this.genericService.patch<any>(this._url, `persona/${id}`, Persona)
  }
  override delete(id: string): Observable<Persona> {
    return this.genericService.delete<any>(this._url, `persona/${id}`)
  }
}
