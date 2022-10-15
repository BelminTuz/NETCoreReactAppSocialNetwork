import { makeAutoObservable } from "mobx";

export default class ActivityStore{
    title = 'Hello from MOB X';

    constructor() {
        makeAutoObservable(this)
    }

    setTitle = () => {
        this.title = this.title + ' updated! ';
    }
}