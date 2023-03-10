using CinemaClient.Model;
using CinemaClient.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows;

namespace CinemaClient.ViewModel;

public class HomeViewModel : ViewModelBase
{
    public string? Searchbar { get; set; }
    public ObservableCollection<Search> SearchResult { get; set; } = new();

    private readonly ISerializeService _serializeService;
    private readonly IDownloadService _downloadService;
    private readonly INavigationService _navigationService;

    public HomeViewModel(ISerializeService serializeService, IDownloadService downloadService, INavigationService navigationService)
    {
        _serializeService = serializeService;
        _downloadService = downloadService;
        _navigationService = navigationService;
    }

    public RelayCommand SearchCommand
    {
        get => new(() =>
        {
            SearchResult.Clear();
            if (Searchbar != null)
            {
                try
                {
                    var json = _downloadService.DownloadJson(UriModel.SearchByMovie(Searchbar));
                    var searchResult = _serializeService.Deserialize<Movie>(json);

                    foreach (var item in searchResult.Search)
                    {
                        SearchResult.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        });
    }

    public RelayCommand<object> InfoCommand
    {
        get => new(param => 
        {
            try
            {
                if (param != null)
                {
                    var json = _downloadService.DownloadJson(UriModel.SearchById(param as string));
                    var data = _serializeService.Deserialize<MovieInfoModel>(json);
                    _navigationService.NavigateTo<InfoViewModel>(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}