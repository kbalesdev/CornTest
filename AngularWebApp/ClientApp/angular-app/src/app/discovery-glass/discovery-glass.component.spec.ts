import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiscoveryGlassComponent } from './discovery-glass.component';

describe('DiscoveryGlassComponent', () => {
  let component: DiscoveryGlassComponent;
  let fixture: ComponentFixture<DiscoveryGlassComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DiscoveryGlassComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DiscoveryGlassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
