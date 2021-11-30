import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {

  public cadastro: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getCadastro();
  }

  public getCadastro(): void {
    this.http.get('https://localhost:5001/api/cliente').subscribe(
      response => this.cadastro = response,
      error => console.log(error)
    );
  }
}
