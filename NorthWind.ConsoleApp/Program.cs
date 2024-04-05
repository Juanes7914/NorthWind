
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application Started.");
