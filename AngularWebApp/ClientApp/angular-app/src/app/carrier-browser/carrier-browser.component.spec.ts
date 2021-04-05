import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarrierBrowserComponent } from './carrier-browser.component';

describe('CarrierBrowserComponent', () => {
  let component: CarrierBrowserComponent;
  let fixture: ComponentFixture<CarrierBrowserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarrierBrowserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarrierBrowserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
