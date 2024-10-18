import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CoreModule, LocalizationService } from '@abp/ng.core';
import { ThemeSharedModule, ToasterService } from '@abp/ng.theme.shared';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BookService } from '../services/book/book.service';
import { Book } from './books';
import { pipe } from 'rxjs';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-books',
  standalone: true,
  imports: [SharedModule, CoreModule, ThemeSharedModule],
  templateUrl: './books.component.html',
  styleUrl: './books.component.scss',
})
export class BooksComponent implements OnInit {
  form: FormGroup;
  isModalOpen = false;

  modalOptions = {
    centered: true,
  };

  rows: Book[] = [];

  constructor(
    private localizationService: LocalizationService,
    private formBuilder: FormBuilder,
    private bookService: BookService,
    private toasterService: ToasterService,
    private datePipe: DatePipe
  ) {
    this.form = this.formBuilder.group({
      title: ['', Validators.required],
      author: ['', Validators.required],
      isbn: ['', Validators.required],
      publishedDate: ['', Validators.required],
      pages: ['', Validators.required],
    });
  }

  ngOnInit() {
    this.bookService.getBooks().subscribe(books => {
      this.rows = books.items;
    });
  }

  columns = [
    { prop: 'title', name: this.localizationService.instant('::Books:Title') },
    { prop: 'author', name: this.localizationService.instant('::Books:Author') },
    { prop: 'isbn', name: this.localizationService.instant('::Books:ISBN') },
    {
      prop: 'publishedDate',
      name: this.localizationService.instant('::Books:PublishDate'),
      pipe: this.datePipe,
    },
    { prop: 'pages', name: this.localizationService.instant('::Books:PagesNumber') },
  ];
  openCreateModal() {
    this.isModalOpen = true;
  }

  createBook() {
    if (this.form.invalid) {
      console.log(this.form);
      Object.values(this.form.controls).forEach(control => {
        control.markAsDirty();
        control.updateValueAndValidity();
      });
      this.toasterService.error('::Invalid:Form');
      return;
    }

    this.bookService.createBook(this.form.value).subscribe(() => {
      this.toasterService.success('::Successfully:Created');
      this.isModalOpen = false;
    });
  }
}
