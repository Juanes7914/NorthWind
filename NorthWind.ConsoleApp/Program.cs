
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

IUserActionWriter Writer = default;

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application Started.");
