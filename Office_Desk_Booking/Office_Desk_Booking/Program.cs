using Microsoft.EntityFrameworkCore;
using OfficeDeskBLL.Services;
using OfficeDeskDAL.Data;
using OfficeDeskDAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DeskDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});

builder.Services.AddScoped<IBookingSeatRepository, BookingSeatRepository>();
builder.Services.AddScoped<BookingSeatService, BookingSeatService>();

builder.Services.AddScoped<IBookingRoomRepository, BookingRoomRepository>();
builder.Services.AddScoped<BookingRoomService, BookingRoomService>();

builder.Services.AddScoped<ILoginTableRepository, LoginTableRepository>();
builder.Services.AddScoped<LoginTableService, LoginTableService>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<EmployeeService, EmployeeService>();

builder.Services.AddScoped<IFloorRepository, FloorRepository>();
builder.Services.AddScoped<FloorService, FloorService>();

builder.Services.AddScoped<IQRScannerRepository, QRScannerRepository>();
builder.Services.AddScoped<QRScannerService, QRScannerService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
