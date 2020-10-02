import { Component, OnInit } from '@angular/core';
import {Socio} from '../models/socio'
import { SocioService } from '../services/socio.service';

@Component({
    selector:"app-socio",
    templateUrl: './socio-list.component.html',
    styleUrls: ['./socio-list.component.css']
})

export class SocioComponent implements OnInit{
    socios: Socio[] = [];
    constructor(private socioService: SocioService){

    }
    ngOnInit(): void {
        this.socioService.getSocios().subscribe({
            next: result => {
                this.socios = result;
            },
            error: err => {
                console.log(err);
            }
        })
    }
}

