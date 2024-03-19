import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn:'root'
})
export class ApiService{
baseUrl="http://localhost:5119";
constructor(private Http: HttpClient){}
register(user:any){
return this.Http.post(this.baseUrl +'Register',user, {
    responseType : 'text',

});
}
}