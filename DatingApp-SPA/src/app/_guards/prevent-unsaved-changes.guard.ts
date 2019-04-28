import { Injectable } from "@angular/core";
import { CanActivate, Router, CanDeactivate } from "@angular/router";
import { Observable } from "rxjs";
import { AlertifyService } from "../_services/alertify.service";
import { AuthService } from "../_services/auth.service";
import { MemberEditComponent } from "../members/member-edit/member-edit.component";

@Injectable({
  providedIn: "root"
})
export class PreventUnsavedChanges
  implements CanDeactivate<MemberEditComponent> {
  constructor(
    private authService: AuthService,
    private router: Router,
    private alertify: AlertifyService
  ) {}

  canDeactivate(
    component: MemberEditComponent
  ): Observable<boolean> | Promise<boolean> | boolean {
    if (component.editForm.dirty) {
      return confirm("Are you sure you want to continue?");
    }
    return true;
  }
}
