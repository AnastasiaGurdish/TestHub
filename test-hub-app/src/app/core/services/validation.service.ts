import { Injectable } from '@angular/core';
import { AbstractControl, ValidatorFn } from '@angular/forms';

@Injectable()
export class ValidationService {
    ValidationService() {}
    public getUsernameErrorMessage(control: AbstractControl) {
        return  control.hasError('maxlength') ? 'Username must be less then 16 symbols' :
                control.hasError('minlength') ? 'Username must be longer then 5 symbols' :
                control.hasError('pattern') ? 'Username must include only A-Z, a-z, А-Я, а-я, 0-9, \".\", \"-\", \"_\"' :
                    '';
                    // control.hasError('required') ? 'Enter a username' :
    }
    public getEmailErrorMessage(control: AbstractControl) {
        return control.hasError('email') ? 'Not a valid Email' :
                    '';
                    // control.hasError('required') ? 'Enter an Email' :
    }

    public getPasswordErrorMessage(control: AbstractControl) {
        return control.hasError('minlength') ? 'Password must be longer then 6 symbols' :
               control.hasError('maxlength') ? 'Password must be no longer then 16 symbols' :
                    '';
                    // control.hasError('required') ? 'You must enter a password' :
    }

    public getConfirmPasswordErrorMessage(control: AbstractControl) {
        return control.hasError('minlength') ? 'Password must be longer then 6 symbols' :
               control.hasError('maxlength') ? 'Password must be no longer then 16 symbols' :
               control.hasError('mismatch') ? 'Passwords must be equal' :
                    '';
                    // control.hasError('required') ? 'Confirm Password' :
    }

    public getRoleSelectErrorMessage(control: AbstractControl) {
        return '';
        // control.hasError('required') ? 'Choose a role' :
    }

      public passwordMatchValidator(verifier: AbstractControl, verifiable: AbstractControl): ValidatorFn {
          return (control: AbstractControl): { [key: string]: any } | null => {
              if (!control.parent) {
                 return null;
              }
              return verifier.value === verifiable.value ? null : { 'mismatch': true };
      };
      }


}