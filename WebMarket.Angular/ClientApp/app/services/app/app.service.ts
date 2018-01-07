import { Injectable } from '@angular/core';
import { Headers, Http, Response, URLSearchParams } from '@angular/http';

import 'rxjs/add/operator/toPromise';

@Injectable()
export class AppService {
    constructor(private http: Http) { }

    private headers = new Headers({ 'Content-Type': 'application/json' });

    getAllStrings(): Promise<string> {
        return this.http.get('http://localhost:50685/api/test')
            .toPromise().then(response => response.json());
    }
}
