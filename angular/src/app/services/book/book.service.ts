import { Rest, RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import { Book, CreateBookDto, PagedResponse } from '../../books/books';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  constructor(private restService: RestService) {}

  createBook(book: CreateBookDto): Observable<null> {
    const request: Rest.Request<CreateBookDto> = {
      method: 'POST',
      url: '/api/app/book',
      body: book,
    };

    return this.restService.request<CreateBookDto, null>(request);
  }

  getBooks(): Observable<PagedResponse<Book>> {
    const request: Rest.Request<null> = {
      method: 'GET',
      url: '/api/app/book',
    };

    return this.restService.request<null, PagedResponse<Book>>(request);
  }
}
