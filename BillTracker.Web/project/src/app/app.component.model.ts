export class AppModel {

    user;
    items;

    constructor(){
        this.user = "Adam";
        this.items = [
            new TodoItem("Wash Dishes", false),
            new TodoItem("Vacuum Carpet", false),
            new TodoItem("Eat Cheetos", true),
        ]
    }
}

export class TodoItem {

    public action:string;
    public done:boolean;

    constructor(action:string, done: boolean){
        this.action = action;
        this.done = done;
    }
}