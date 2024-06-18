import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'POS_IMS';
  roles: any;

  constructor(private http: HttpClient){}
  ngOnInit(): void {
    this.http.get('https://192.168.1.103:7276').subscribe({
      next: response => this.roles = response,
      error: error => console.log(error),
      complete: () => console.log("Request has finalised...")
    });
  }
}
