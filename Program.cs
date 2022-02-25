using StoreSharp;

using var ctx = new StoreSharpContext();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region config
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
#endregion

#region api

#endregion

app.Run();
