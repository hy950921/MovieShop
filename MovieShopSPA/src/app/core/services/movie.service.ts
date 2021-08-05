import { Injectable } from '@angular/core';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';
import { Observable } from 'rxjs';
import {Movie} from 'src/app/shared/models/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
//     <!-- Ctrl +/  Comments  -->
// <!-- Ctrl +P   Searching by file names in your project  -->
// <!-- Ctrl + Shift + P  Searching VC Code setting -->
// <!-- Alt+Shift+F  Formatting your code  -->
// <!-- Alt + O swtching between component and Template (View) -->

  constructor(private http: HttpClient) { }
      // make an ajax HTTP call to API

  getTopRevenueMovies() : Observable<MovieCard[]> {

      return this.http.get('https://localhost:44316/api/movies/toprevenue')
      .pipe(map(resp => resp as MovieCard[]));
  }

  getMovieDetails(id : number) : Observable<Movie> {
    
    return this.http.get('https://localhost:44316/api/movies/' + id).pipe(map(resp => resp as Movie));
  }
      
  
}
