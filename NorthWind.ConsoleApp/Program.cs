
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;


IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application Started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azúcar Refinada");