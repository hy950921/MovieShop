import { Component, OnInit } from '@angular/core';
import { MovieService } from '../../core/services/movie.service';
import { ActivatedRoute } from '@angular/router';
import { MovieDetails } from 'src/app/shared/models/movieDetails';
import { Movie } from 'src/app/shared/models/movie';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {
    movie!: Movie;
    movieId!: number;

//   constructor(private route: ActivatedRoute, private movieService: MovieService) { }

//     //get the movie id from the URL and call the MovieService
//   ngOnInit(): void {
//       this.route.paramMap.subscribe(
//           p=> {
//             this.movieId = Number(p.get('id'));
//             this.movieService.getMovieDetails(this.movieId).subscribe(
//                 m => {
//                     this.movie = m;
//                 }
//             )
//           }
//       )
//   }
constructor( private route: ActivatedRoute, private movieService : MovieService) { }

    ngOnInit(): void {
        this.route.paramMap.subscribe(
                p => {
                    this.movieId = +p.get('id')!;

                    //call movie service
                    this.movieService.getMovieDetails(this.movieId).subscribe(m=>{
                        this.movie = m;
                    })
                }
        )
    }


}
