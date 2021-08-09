import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
    private headers: HttpHeaders | undefined;

    constructor(protected http: HttpClient) {
        this.headers = new HttpHeaders();
        this.headers.append('Content-Type', 'application/json');
    }

    create(path: string, resource: any, options?: any): Observable<any> {
        return this.http
            .post('https://localhost:44316/api'.concat(path), resource, { headers: this.headers })
            .pipe(
                map((response) => response)
            );
    }
}
