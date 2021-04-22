import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NovaModelsComponent } from './nova-models.component';

describe('NovaModelsComponent', () => {
  let component: NovaModelsComponent;
  let fixture: ComponentFixture<NovaModelsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NovaModelsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NovaModelsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
