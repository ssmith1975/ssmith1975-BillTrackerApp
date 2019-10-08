import { Component } from '@angular/core';
import {AppModel, TodoItem} from './app.component.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent {
  title = 'project';
  model = new AppModel();
  test = this.model.user;



  getName(){
    return this.model.user;
  }

  getTodoItems(){
    return this.model.items.filter(item => !item.done);
  } 

  addItem(newItem){
    if(newItem != ""){
      this.model.items.push(new TodoItem(newItem, false));
    }
  }

}
