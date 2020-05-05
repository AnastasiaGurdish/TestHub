//import { MatSnackBar, MatSnackBarConfig, MatSnackBarRef } from '@angular/material/snack-bar';
import { SnackBarService } from './snack-bar.service';
import { Injectable, NgZone } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { take } from 'rxjs/operators';

@Injectable()
export class PopupService {
    // private config: MatSnackBarConfig = {
    //     duration: 7000,
    //     horizontalPosition: 'right',
    //     verticalPosition: 'bottom'
    // };

    constructor( private snackBar: SnackBarService) { }

    public showError(message: string) {
        if (message) {
                this.snackBar.openSnackBar(message);
        }
    }

    public showMessage(message: string) {
        if (message) {
                this.snackBar.openSnackBar(message);
        }
    }
}