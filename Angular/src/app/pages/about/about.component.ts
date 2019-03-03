import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { About } from 'src/app/models/about.interface';
import { Fact } from 'src/app/models/fact.interface';
import { Blog } from 'src/app/models/blog.interface';


@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})

export class AboutComponent implements OnInit {
  public about: About;
  public facts: Fact[];
  public blogs: Blog[];

  constructor(private http: HttpClient) {
    this.GetAbout();
    this.GetFacts();
    this.GetBlogs();
  }

  ngOnInit() {
  }

  GetAbout() {
    this.http.get<About>("https://localhost:5001/api/about").subscribe(result => {
      this.about = result;
    }, error => console.log(error));
  }

  GetFacts() {
    this.http.get<Fact[]>("https://localhost:5001/api/fact").subscribe(result => {
      this.facts = result;
    });
  }

  GetBlogs() {
    this.http.get<Blog[]>("https://localhost:5001/api/blog").subscribe(result => {
      this.blogs = result;
    });
  }
}

