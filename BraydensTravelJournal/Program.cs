using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BraydensTravelJournal.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BraydensTravelJournalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BraydensTravelJournalContext") ?? throw new InvalidOperationException("Connection string 'BraydensTravelJournalContext' not found.")));

var app = builder.Build();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
