import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  public contactGroup: FormGroup;
  submitted = false;

  constructor(private http: HttpClient, private formBuilder: FormBuilder) {
    this.contactGroup = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      tel: ['', [Validators.required, Validators.minLength(10)]],
      country: [''],
      message: ['', Validators.required],
    })
  }

  ngOnInit() {
  }

  get f() { return this.contactGroup.controls; }

  onSubmit() {
    this.submitted = true;
    if (this.contactGroup.invalid) {
      return;
    }

    this.http.post<Boolean>("https://localhost:5001/api/contact", this.contactGroup.value).subscribe(result => {
      if (result) {
        alert("Message gonderildi");
        this.contactGroup.reset();
      }
    })

  }
}
