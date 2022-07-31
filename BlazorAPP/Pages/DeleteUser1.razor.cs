using DataAccess;
using Microsoft.AspNetCore.Components;

namespace BlazorAPP.Pages;

public partial class DeleteUser1 : ComponentBase
{
    [Parameter]
    public int userId { get; set; }

    HttpClient Http = new HttpClient();
    UserModel? user = new UserModel();


    protected override async Task OnInitializedAsync()
    {
        user = await Http.GetFromJsonAsync<UserModel>("https://localhost:7000/Users/" + Convert.ToInt32(userId));
    }

    public async Task RemoveUser(int userID, NavigationManager navigationManager)
    {
        await Http.DeleteAsync("https://localhost:7000/Users?id=" + userID);
        Cancel();
    }

    





    public void Cancel()
    {
        NavigationManager.NavigateTo("/UserData");
    }



}
