import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { God } from '../interfaces/god';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SmiteApiService {
  constructor(private http: HttpClient) {}

  private baseUrl = 'https://localhost:7233/api/';
  // httpOptions = {
  //   headers: new HttpHeaders({
  //     'Content-Type': 'application/json',
  //   })
  // };

  getGods(): Observable<God[]> {
    return this.http.get<God[]>(this.baseUrl + 'Gods');
  }

  getGod(id: number): Observable<God> {
    return this.http.get<God>(this.baseUrl + 'Gods/' + id);
  }
}
