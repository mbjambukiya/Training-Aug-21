import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';


@Component({
  selector: 'app-crisis-list',
  templateUrl: './crisis-list.component.html',
  styleUrls: ['./crisis-list.component.css']
})

export class CrisisListComponent implements OnInit {

  public parameterValue: string | null = "";

  constructor(
    private _router: Router,
    private _activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    // this._activatedRoute.params.subscribe(parameter => {
    //   this.parameterValue = parameter['parameter']
    //   // this._router.navigate(['crisis-center/4'])
    //   // this.parameterValue = parameter['parameter']
    // })

    this._activatedRoute.paramMap.subscribe((data: ParamMap) => {
      this.parameterValue = data.get('parameter')
    })

  }
}