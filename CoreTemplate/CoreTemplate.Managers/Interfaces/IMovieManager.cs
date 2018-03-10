﻿using CoreTemplate.ViewModels.Movie;

namespace CoreTemplate.Managers.Interfaces
{
    public interface IMovieManager
    {
        MovieViewModel Get(int? id);

        MoviesViewModel GetAll();

        CrewMemberViewModel GetNewPerson(int index);

        MovieViewModel Save(MovieViewModel vm);

        MovieViewModel Delete(int id);
    }
}
