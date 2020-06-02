@page "/delete/{trayID:int}"
@using Growing.Shared.Models
@inject HttpClient HttpClient
@inject NavigationManager urlNavigationManager

<h2>Delete Tray</h2>
<h3>Are you sure you want to delete tray with id : @trayID</h3>
<br />

<div class="col-md-4">
    <table class="table">
        <tr>
            <td>Name</td>
            <td>@tray.Name</td>
        </tr>
        <tr>
            <td>Department</td>
            <td>@tray.Department</td>
        </tr>
        <tr>
            <td>City</td>
            <td>@tray.City</td>
        </tr>
        <tr>
            <td>SowingDate</td>
            <td>@tray.SowingDate</td>
        </tr>
    </table>
    <div class="form-group">
        <button class="btn btn-danger" @onclick="(async () => await Delete())">Delete</button>
        <button class="btn btn-light" @onclick="Cancel">Cancel</button>
    </div>
</div>

@code {
    [Parameter]
public int trayID { get; set; }

Tray tray = new Tray();

protected override async Task OnInitializedAsync()
{
    tray = await HttpClient.GetFromJsonAsync<Tray>("/api/Tray/Details/" + trayID);
}

protected async Task Delete()
{
    await HttpClient.DeleteAsync("api/Tray/Delete/" + Convert.ToInt32(trayID));
    urlNavigationManager.NavigateTo("/fetchtray");
}

void Cancel()
{
    urlNavigationManager.NavigateTo("/fetchtray");
}


}
