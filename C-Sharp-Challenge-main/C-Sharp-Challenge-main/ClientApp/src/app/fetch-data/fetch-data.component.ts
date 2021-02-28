import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public people: Person[];
  httpClient: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get(baseUrl + 'api/CodingChallenge/Populate').subscribe(result => {
      this.getPeople();
    }, error => console.error(error));

    this.httpClient = http;
    this.baseUrl = baseUrl;
  }

  insert() {
    this.httpClient.post(this.baseUrl + 'api/CodingChallenge/Insert', null).subscribe(result => {
      this.getPeople();
    }, error => console.error(error));

  }

  getPeople() {
    this.httpClient.get<Person[]>(this.baseUrl + 'api/CodingChallenge/People').subscribe(result => {
      this.people = result;
      this.people.forEach((x) => {
        if(x.friends !== null && x.friends !== undefined) {
          x.friendsNameList = x.friends.map((x) => { return x.firstName + ' ' + x.lastName }).join(",");
        }
      })
    }, error => console.error(error));
  }
}

interface Person {
  firstName: string;
  lastName: string;
  age: number;
  dateOfBirth?: Date;
  friends: Person[];
  Friends: string;
  friendsNameList: string;
}
