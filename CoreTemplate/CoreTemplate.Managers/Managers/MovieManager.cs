﻿using AutoMapper;
using CoreTemplate.Accessors.Interfaces;
using CoreTemplate.Accessors.Models.DTO;
using CoreTemplate.Managers.Interfaces;
using CoreTemplate.Managers.ViewModels.Movie;
using System.Collections.Generic;

/*
 * TODO: Make this my own
 */

namespace CoreTemplate.Managers.Managers
{
    public class MovieManager : IMovieManager
    {
        private IMovieAccessor _movieAccessor;

        public MovieManager(IMovieAccessor movieAccessor)
        {
            _movieAccessor = movieAccessor;
        }

        public MovieViewModel GetMovie(int id)
        {
            var dto = _movieAccessor.Get(id);
            var vm = Mapper.Map<MovieViewModel>(dto);

            return vm;
        }

        public MoviesViewModel GetAllMovies()
        {
            var dtos = _movieAccessor.GetAll();
            var movieVms = Mapper.Map<List<MovieViewModel>>(dtos);

            return new MoviesViewModel { Movies = movieVms };
        }

        public MovieViewModel SaveMovie(MovieViewModel vm)
        {
            var dto = Mapper.Map<MovieDTO>(vm);
            var dtoNew = _movieAccessor.Save(dto);
            var vmNew = Mapper.Map<MovieViewModel>(dtoNew);

            return vmNew;
        }

        public MovieViewModel DeleteMovie(int id)
        {
            var dto = _movieAccessor.Delete(id);
            var vm = Mapper.Map<MovieViewModel>(dto);

            return vm;
        }
    }
}
