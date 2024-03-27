import { Routes } from '@angular/router';
import { LoginComponent } from './login/login/login.component';
import { EmployeeDashboardComponent } from './employee-dashboard/employee-dashboard/employee-dashboard.component';
import { AuthGuard } from './shared/auth.guard';
import { SignupComponent } from './signup/signup/signup.component';

export const routes: Routes = [
    {path:'', redirectTo:'login',pathMatch:'full'},
    {path:'login', component:LoginComponent},
    {path:'dashboard', component:EmployeeDashboardComponent,canActivate:[AuthGuard]},
    {path:'signup', component: SignupComponent}
];




