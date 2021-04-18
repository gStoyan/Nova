import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NovaModelComponent } from './nova-model.component';

describe('NovaModelComponent', () => {
  let component: NovaModelComponent;
  let fixture: ComponentFixture<NovaModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NovaModelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NovaModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
