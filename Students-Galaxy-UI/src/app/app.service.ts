import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap, Observable, of } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  })
};

@Injectable()
export class AppService {

  constructor(private http: HttpClient) { }

  getAction(url: string) {
    return this.http.get(url, httpOptions).pipe(
      map((response: any) => response.responseData),
      tap(next => { }),
      catchError(this.handleError())
    );
  }

  private handleError<T>() {
    return (error: any): Observable<T> => {

      return of(error as T)
    };
  }

}
