import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CssDay5Component } from './css-day5.component';

describe('CssDay5Component', () => {
  let component: CssDay5Component;
  let fixture: ComponentFixture<CssDay5Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CssDay5Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CssDay5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
