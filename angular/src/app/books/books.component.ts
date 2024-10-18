import { Component } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CoreModule, LocalizationService } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-books',
  standalone: true,
  imports: [SharedModule, CoreModule, ThemeSharedModule],
  templateUrl: './books.component.html',
  styleUrl: './books.component.scss',
})
export class BooksComponent {
  form: FormGroup;
  isModalOpen = false;

  modalOptions = {
    centered: true,
  };

  rows = [
    { id: 1, name: 'Book 1', author: 'Author 1' },
    { id: 2, name: 'Book 2', author: 'Author 2' },
    { id: 3, name: 'Book 3', author: 'Author 3' },
  ];

  constructor(private localizationService: LocalizationService) {}

  columns = [
    { name: this.localizationService.instant('::Books:Name') },
    { name: this.localizationService.instant('::Books:Author') },
  ];
  openCreateModal() {
    this.isModalOpen = true;
  }

  createBook() {
    this.isModalOpen = false;
  }
}
