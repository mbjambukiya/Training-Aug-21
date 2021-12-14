import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObervableDemoComponent } from './obervable-demo.component';

describe('ObervableDemoComponent', () => {
  let component: ObervableDemoComponent;
  let fixture: ComponentFixture<ObervableDemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ObervableDemoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ObervableDemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
