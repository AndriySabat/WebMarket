import { Component } from '@angular/core';
import { AppService } from '../../services/app/app.service';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers:[AppService],
})
export class AppComponent implements OnInit {
    constructor(
        private appService:AppService
    ) { }

    customString: string;

    ngOnInit(): void{
        this.appService.getAllStrings().then(str=>this.customString=str);
    }
}
