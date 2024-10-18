export interface CreateBookDto {
  name: string;
  author: string;
}

export interface Book {
  id: string;
  name: string;
  author: string;
}

export interface PagedResponse<T> {
  totalCount: number;
  items: T[];
}
