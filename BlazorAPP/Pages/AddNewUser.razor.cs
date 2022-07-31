using Microsoft.AspNetCore.Components;
using DataAccess;
namespace BlazorAPP.Pages;
public partial class AddNewUser : ComponentBase
{
    HttpClient Http = new HttpClient();
     



    [Parameter]
    public int userId { get; set; } 

    protected string? Title { get; set; } = "Add";

    protected UserModel? user { get; set; } = new();



    protected override async Task OnParametersSetAsync()
    {
        if (userId != 0)
        {

            
            Title = "Edit";
            
            user = await Http.GetFromJsonAsync<UserModel>("https://localhost:7000/Users/" + userId);
        }
    }
    public async Task SaveUser()
    {
        if (user.Id != 0)
        {
            await Http.PutAsJsonAsync("https://localhost:7000/Users", user);
        }
        else
        {
            await Http.PostAsJsonAsync("https://localhost:7000/Users", user);
        }
        Cancel();
    }
    public void Cancel()
    {
        NavigationManager.NavigateTo("/UserData");
    }

}

