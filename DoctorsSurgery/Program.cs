using DoctorsSurgery.Database;
using DoctorsSurgery.Repositories;
using DoctorsSurgery.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSurgeryDb(builder.Configuration);
builder.Services.AddTransient<IPatientService, PatientService>();
builder.Services.AddTransient<IDoctorService, DoctorService>();
builder.Services.AddTransient<ISlotService, SlotService>();
builder.Services.AddTransient<IAppointmentService, AppointmentService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello Doctors Surgery!");

app.MapControllers();   
app.Run();
