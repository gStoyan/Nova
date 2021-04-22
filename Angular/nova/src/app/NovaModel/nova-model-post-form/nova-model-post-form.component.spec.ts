import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NovaModelPostFormComponent } from './nova-model-post-form.component';

describe('NovaModelPostFormComponent', () => {
  let component: NovaModelPostFormComponent;
  let fixture: ComponentFixture<NovaModelPostFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NovaModelPostFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NovaModelPostFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
