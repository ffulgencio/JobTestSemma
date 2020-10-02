import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Socio } from '../models/socio';
import {Observable} from 'rxjs';

@Injectable({
    providedIn:'root'
})
export class SocioService{
    baseUrl:string;
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    getSocios(): Observable<Socio[]> {
        return this.http.get<Socio[]>( this.baseUrl + 'Socio');
    }

    getById(id): Observable<Socio>{
        return this.http.get<Socio>(`{this.baseUrl} Socio/{id}`);
    }


}