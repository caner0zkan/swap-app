import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StatusproductComponent } from './statusproduct.component';

describe('StatusproductComponent', () => {
  let component: StatusproductComponent;
  let fixture: ComponentFixture<StatusproductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StatusproductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StatusproductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
