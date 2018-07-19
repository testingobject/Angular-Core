import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent {
  public users: any[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + '/api/user/list').subscribe(result => {
      console.log(result);
      this.users = result;
    }, error => console.log(error))
  }

  ngOnInit() {
  }

}
