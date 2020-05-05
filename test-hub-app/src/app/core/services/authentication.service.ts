import { Injectable } from '@angular/core';
import { User } from '../../shared/models/user.model';
import { JwtResponse } from '../../shared/models/jwt-response.model';
import { HttpClient } from '@angular/common/http';
import { tap } from  'rxjs/operators';
import { Observable, BehaviorSubject } from  'rxjs';

@Injectable()
export class AuthenticationService {

  AUTH_SERVER = "http://localhost:4200";
  authSubject  =  new  BehaviorSubject(false); ///This variable tracks the user's authentication state. false means the user is not authenticated yet.

    constructor(private httpClient: HttpClient) { }
  
    public login(userInfo: User){
      localStorage.setItem('ACCESS_TOKEN', "access_token");
    }
  
    public isLoggedIn(){
      return localStorage.getItem('ACCESS_TOKEN') !== null;
    }
  
    public logout(){
      localStorage.removeItem('ACCESS_TOKEN');
    }



    register(user: User): Observable<JwtResponse> {
      return this.httpClient.post<JwtResponse>(`${this.AUTH_SERVER}/signup`, user).pipe(
        tap((res:  JwtResponse ) => {
          if (res.user) {
            localStorage.set("ACCESS_TOKEN", res.user.access_token);
            localStorage.set("EXPIRES_IN", res.user.expires_in);
            this.authSubject.next(true);
          }
        })
  
      );
    }


    signIn(user: User): Observable<JwtResponse> {
      return this.httpClient.post(`${this.AUTH_SERVER}/signin`, user).pipe(
        tap(async (res: JwtResponse) => {
          if (res.user) {
            localStorage.set("ACCESS_TOKEN", res.user.access_token);
            localStorage.set("EXPIRES_IN", res.user.expires_in);
            this.authSubject.next(true);
          }
        })
      );
    }

    signOut() {
      localStorage.removeItem("ACCESS_TOKEN");
      localStorage.removeItem("EXPIRES_IN");
      this.authSubject.next(false);
    }

    isAuthenticated() {
      return  this.authSubject.asObservable();
  }

  }