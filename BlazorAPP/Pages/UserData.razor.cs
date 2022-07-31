using Microsoft.AspNetCore.Components;
using DataAccess;

namespace BlazorAPP.Pages;

public partial class UserData : ComponentBase
{

    public List<UserModel>? userList = new();
    public List<UserModel>? searchUserData = new();
    public UserModel user = new();
    public string SearchString { get; set; } = string.Empty;
    HttpClient Http = new HttpClient();


    

    protected override async Task OnInitializedAsync()
    {
        await GetUser();
    }
    

        protected async Task GetUser()
    {
        
        userList = await Http.GetFromJsonAsync<List<UserModel>>("https://localhost:7000/Users");
            searchUserData = userList;
        
    }


    protected void FilterUser()
    {
        if (!string.IsNullOrEmpty(SearchString))
        {
            userList = searchUserData.Where(x => x.FirstName.IndexOf(SearchString, StringComparison.OrdinalIgnoreCase) != -1).ToList();
        }
        else
        {
            userList = searchUserData;
        }
    }
    protected void DeleteConfirm(int userID)
    {
        user = userList.FirstOrDefault(x => x.Id == userID);
    }
    public void ResetSearch()
    {
        SearchString = string.Empty;
        userList = searchUserData;
    }



}
