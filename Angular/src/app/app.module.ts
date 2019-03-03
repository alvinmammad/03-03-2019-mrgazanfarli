import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { ServiceListComponent } from './pages/services/service-list/service-list.component';
import { ServiceDetailComponent } from './pages/services/service-detail/service-detail.component';
import { ProjectListComponent } from './pages/projects/project-list/project-list.component';
import { ProjectDetailsComponent } from './pages/projects/project-details/project-details.component';
import { BlogListComponent } from './pages/blog/blog-list/blog-list.component';
import { BlogDetailsComponent } from './pages/blog/blog-details/blog-details.component';
import { FaqComponent } from './pages/faq/faq.component';
import { PageNotFoundComponent } from './error/page-not-found/page-not-found.component';


// routing

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'services', component: ServiceListComponent },
  { path: 'service/:slug', component: ServiceDetailComponent },
  { path: 'projects', component: ProjectListComponent },
  { path: 'project/:slug', component: ProjectDetailsComponent },
  { path: 'blog', component: BlogListComponent },
  { path: 'blog/:slug', component: BlogDetailsComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'faq', component: FaqComponent },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    ContactComponent,
    ServiceListComponent,
    ServiceDetailComponent,
    ProjectListComponent,
    ProjectDetailsComponent,
    BlogListComponent,
    BlogDetailsComponent,
    FaqComponent,
    PageNotFoundComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(
      appRoutes
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
