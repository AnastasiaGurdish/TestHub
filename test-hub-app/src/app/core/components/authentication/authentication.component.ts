import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService } from '../../services/authentication.service';
import { ValidationService } from '../../services/validation.service';
import { User } from '../../../shared/models/user.model';

@Component({
  selector: 'app-authentication',
  templateUrl: './authentication.component.html',
  styleUrls: ['./authentication.component.scss']
})


export class AuthenticationComponent implements OnInit {
  authForm: FormGroup;
  isSubmitted  =  false;
  public hide = true;
  // private successMessage = "Success!";
  // private error = "Authentication is failed! Check your form!";

  constructor(public validator: ValidationService, private authService: AuthenticationService, private router: Router, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.authForm  =  this.formBuilder.group({
      username: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(16)]],
      password: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(16)]]
  });
  }

  get formControls() { return this.authForm.controls; }

  signIn(){
    const username = this.authForm.controls['username'];
    const password = this.authForm.controls['password'];

    if(this.authForm.invalid){
      this.AuthFailure(this.isSubmitted);
      return;
    }
    if (username.invalid) {
      // this.popupService.showError(this.validator.getUsernameErrorMessage(username));
      return;
    }
    if (password.invalid) {
      // this.popupService.showError(this.validator.getPasswordErrorMessage(password));
      return;
    }
    if(this.authForm.valid){
      this.isSubmitted = true;
      this.AuthSuccess(this.isSubmitted);
    }

    this.authService.signIn(this.authForm.value).subscribe((res)=>{
      console.log("Logged in!");
      this.router.navigateByUrl('/profile');
    });  
    //this.authService.login(this.authForm.value);
    //this.router.navigateByUrl('/profile');
  }

  private AuthSuccess(isRegistrationSuccessful: boolean | undefined): void {
    if (isRegistrationSuccessful === true) {
      // this.popupService.showMessage(this.successMessage);
    }
  }

  private AuthFailure(isRegistrationUnSuccessful: boolean | undefined): void {
    if (isRegistrationUnSuccessful === false){}
      // this.popupService.showMessage(this.error);
  }

}
