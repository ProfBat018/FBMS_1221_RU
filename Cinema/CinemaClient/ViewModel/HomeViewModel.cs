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

    public HomeViewModel(ISerializeService serializeService, IDownloadService downloadService)
    {
        _serializeService = serializeService;
        _downloadService = downloadService;
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
                    var json = _downloadService.DownloadJson(Searchbar);
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
}