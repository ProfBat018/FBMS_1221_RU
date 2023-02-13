using MVP.Model;
using MVP.Service.Classes;
using MVP.Service.Interfaces;
using MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenter
{
    internal class MoviePresenter
    {
        private MainView view;

        private SearchService searchService = new(new JsonService(), new DeserializeService());
        public MoviePresenter(MainView view)
        {
            this.view = view;
        }

        public void Search(string? title)
        {
            try
            {
                MovieModel movie = searchService.SearchByTitle(title);
                view.Movie = movie;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
