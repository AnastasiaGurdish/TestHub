import { Component, OnInit, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, Validators, FormControl, FormBuilder } from '@angular/forms';
import { AuthenticationService } from '../../services/authentication.service';
import { ValidationService } from '../../services/validation.service';
import { PopupService } from '../../services/popup.service';
import { User } from '../../../shared/models/user.model';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit, AfterViewInit { 
 registerForm: FormGroup;
 private successMessage = "Success!";
 private error = "Registration is failed! Check your form!";
 public hide = true;
 isRegistered  =  false;

  //  public registerForm  =  new FormGroup({
  //    username: new FormControl('', [Validators.required, Validators.minLength(5), Validators.maxLength(16)]),
  //    email: new FormControl('', [Validators.required, Validators.email]),
  //    password: new FormControl('', [Validators.required, Validators.minLength(6), Validators.maxLength(16)]),
  //    passwordConfirm: new FormControl('', [Validators.required, Validators.minLength(6), Validators.maxLength(16)]),
  //    roleSelect: new FormControl('', Validators.required)});

  Roles: any = [
    {"id": 1, "name": "Teacher"},
    {"id": 2, "name": "Student"}, 
    {"id": 3, "name": "Admin"}
  ];  

  constructor (
    public validator: ValidationService, 
    private popupService: PopupService, 
    private authService: AuthenticationService, 
    private router: Router,
    private formBuilder: FormBuilder) { }
  
  ngOnInit() { 
    this.registerForm = this.formBuilder.group({
      username: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(16)]],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(16)]],
      passwordConfirm: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(16)]],
      roleSelect: ['', [Validators.required]]})
   }

  public ngAfterViewInit(): void{
      this.registerForm.controls['passwordConfirm'].setValidators(this.validator.passwordMatchValidator(this.registerForm.controls['password'],this.registerForm.controls['passwordConfirm']));
  }

  get formControls() { return this.registerForm.controls; }

  public register(){
    const username = this.registerForm.controls['username'];
    const email = this.registerForm.controls['email'];
    const password = this.registerForm.controls['password'];
    const passwordConfirm = this.registerForm.controls['passwordConfirm'];
    const roleSelect = this.registerForm.controls['roleSelect'];

    if(this.registerForm.invalid){
      this.registerFailure(this.isRegistered);
      return;
    }

    if (username.invalid) {
      this.popupService.showError(this.validator.getUsernameErrorMessage(username));
      return;
    }
    if (email.invalid) {
      this.popupService.showError(this.validator.getEmailErrorMessage(email));
      return;
    }
    if (password.invalid) {
      this.popupService.showError(this.validator.getPasswordErrorMessage(password));
      return;
    }
    if (passwordConfirm.invalid) {
      this.popupService.showError(this.validator.getConfirmPasswordErrorMessage(passwordConfirm));
      return;
    }
    if(roleSelect.invalid) {
      this.popupService.showError(this.validator.getRoleSelectErrorMessage(username));
      return;
    }
    if(this.registerForm.valid){
      this.isRegistered = true;
      this.registerSuccess(this.isRegistered);
    }
    
    this.authService.register(this.registerForm.value).subscribe((res) => {
      console.log("Registration successfull!");
      this.router.navigateByUrl('/profile');
    });

   // this.authService.login(this.registerForm.value);
  // this.router.navigateByUrl('/profile');
  }

  private registerSuccess(isRegistrationSuccessful: boolean | undefined): void {
    if (isRegistrationSuccessful === true) {
      this.popupService.showMessage(this.successMessage);
    }
  }

  private registerFailure(isRegistrationUnSuccessful: boolean | undefined): void {
    if (isRegistrationUnSuccessful === false)
      this.popupService.showMessage(this.error);
  }
}