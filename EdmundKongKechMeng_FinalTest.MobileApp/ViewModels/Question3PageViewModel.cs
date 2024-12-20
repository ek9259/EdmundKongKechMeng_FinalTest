using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EdmundKongKechMeng_FinalTest.MobileApp.Models;
using EdmundKongKechMeng_FinalTest.MobileApp.Services;

namespace EdmundKongKechMeng_FinalTest.MobileApp.ViewModels;
public partial class Question3PageViewModel : ObservableObject
{
    private readonly PostRecordService _postRecordService;

    [ObservableProperty]
    private ObservableCollection<PostRecord> _postRecords;

    public Question3PageViewModel(PostRecordService postRecordService)
    {
        _postRecordService = postRecordService;
        LoadPostRecordsAsync();
    }

    private async void LoadPostRecordsAsync()
    {
        try
        {
            var records = await _postRecordService.GetPostRecord();
            
            PostRecords.Clear();
            foreach (var record in records)
            {
                PostRecords.Add(record);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading post records: {ex.Message}");
        }
    }

    [RelayCommand]
    public async Task GoToAddPostPageAsync()
    {
        await Shell.Current.GoToAsync("AddPostPage");
    }
}