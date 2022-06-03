import { Component, OnInit } from '@angular/core';
import { God } from '../../interfaces/god';
import { SmiteApiService } from '../../services/smite-api.service';

@Component({
  selector: 'app-gods',
  templateUrl: './gods.component.html',
  styleUrls: ['./gods.component.css'],
})
export class GodsComponent implements OnInit {
  constructor(private smiteApiService: SmiteApiService) {}

  otherGod: God = {} as God;
  gods: God[] = [];

  ngOnInit(): void {
    this.getGods();
  }

  getGods(): void {
    this.smiteApiService.getGods().subscribe((x) => (this.gods = x));
    this.smiteApiService.getGod(2110).subscribe((x) => (this.otherGod = x));
  }
}
