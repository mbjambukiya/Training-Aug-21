import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeftbarAdsComponent } from './leftbar-ads.component';

describe('LeftbarAdsComponent', () => {
  let component: LeftbarAdsComponent;
  let fixture: ComponentFixture<LeftbarAdsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeftbarAdsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LeftbarAdsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
