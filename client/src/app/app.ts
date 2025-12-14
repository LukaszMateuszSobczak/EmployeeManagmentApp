import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  private http = inject(HttpClient);
  private apiUrl = "https://localhost:7207"
  protected readonly title = signal('System zarządzania pracownikami');

  protected employees = signal<any>([]);

  ngOnInit(): void {
    this.http.get("https://localhost:7207/api/employe").subscribe({
      next: response => this.employees.set(response),
      error: ere => console.log(ere),
      complete: () => console.log('Completed fetching employees')
    })
  }
}
