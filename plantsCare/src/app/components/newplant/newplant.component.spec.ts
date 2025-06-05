import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewplantComponent } from './newplant.component';

describe('NewplantComponent', () => {
  let component: NewplantComponent;
  let fixture: ComponentFixture<NewplantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewplantComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NewplantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
