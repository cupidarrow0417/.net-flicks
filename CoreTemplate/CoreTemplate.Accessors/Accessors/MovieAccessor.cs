﻿using AutoMapper;
using CoreTemplate.Accessors.Accessors.Base;
using CoreTemplate.Accessors.Database;
using CoreTemplate.Accessors.Interfaces;
using CoreTemplate.Accessors.Models.DTO;
using CoreTemplate.Accessors.Models.EF;
using CoreTemplate.Accessors.Models.EF.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreTemplate.Accessors.Accessors
{
    public class MovieAccessor : EntityAccessor<Entity>, IMovieAccessor
    {
        public MovieAccessor(CoreTemplateContext db) : base(db)
        {
        }

        public MovieDTO Get(int id)
        {
            var entity = _db.Movies
                .Include(x => x.Cast).ThenInclude(x => x.Person)
                .Include(x => x.Crew).ThenInclude(x => x.Person)
                .Include(x => x.Crew).ThenInclude(x => x.Department)
                .Include(x => x.Genres).ThenInclude(x => x.Genre)
                .Single(x => x.Id == id);

            var dto = Mapper.Map<MovieDTO>(entity);

            return dto;
        }

        public List<MovieDTO> GetAll()
        {
            var entities = _db.Movies
                .Include(x => x.Genres).ThenInclude(x => x.Genre)
                .ToList();

            var dtos = Mapper.Map<List<MovieDTO>>(entities);

            return dtos;
        }

        public MovieDTO Save(MovieDTO dto)
        {
            var entity = Mapper.Map<Movie>(dto);

            _db.Movies.Update(entity);
            _db.SaveChanges();

            dto = Mapper.Map<MovieDTO>(entity);

            return dto;
        }

        public MovieDTO Delete(int id)
        {
            var entity = _db.Movies.Single(x => x.Id == id);

            _db.Movies.Remove(entity);
            _db.SaveChanges();

            var dto = Mapper.Map<MovieDTO>(entity);

            return dto;
        }
    }
}
