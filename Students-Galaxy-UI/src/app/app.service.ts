import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs';

@Injectable()
export class AppService {

  constructor(private http: HttpClient) { }

  getAction(url: string) {
    return this.http.get(url).pipe(
      map((response: any) => response.responseData),
      // tap(_ => { }),
      // catchError(this.)
    );
  }
}
