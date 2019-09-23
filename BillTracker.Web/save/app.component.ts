import { Component } from '@angular/core';
import { AppModel } from './app.component.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  model = new AppModel();
  test = this.model.user;

  getName(){
    return this.model.user;
  }

  getTodoItems(){
    return this.model.items;
  }
}
