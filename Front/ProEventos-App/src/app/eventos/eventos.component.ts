import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  larguraImg: number = 50;
  margemImg: number = 2;
  mostrarImagem: boolean = true;
  private _filtro: string = '';

  public get filtro(): string {
    return this._filtro;
  }
  public set filtro(value: string) {
    this._filtro = value;
    this.eventosFiltrados = this.filtro ? this.filtrarEventos(this.filtro) : this.eventos;
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
    this.alterarImagem();
  }

  alterarImagem(){
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos() : void {
    this.http.get('https://localhost:5001/evento').subscribe(
    response => {
      this.eventos = response;
      this.eventosFiltrados = this.eventos; // inicializa a lista filtrada
    },
    error => console.log(error)
    );
  }

  public eventosFiltrados: any = [];

  private filtrarEventos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: { tema: string; local: string }) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

}
