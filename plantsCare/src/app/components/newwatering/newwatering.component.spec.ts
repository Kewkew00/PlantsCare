import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewwateringComponent } from './newwatering.component';

describe('NewwateringComponent', () => {
  let component: NewwateringComponent;
  let fixture: ComponentFixture<NewwateringComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewwateringComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NewwateringComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
