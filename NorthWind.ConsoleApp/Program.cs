
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;


IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application Started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azúcar Refinada");

/*     IMPLEMENTACIONES DE TRES PRINCIPIOS IMPORTANTES
 * AppLogger y los Writers: Responsabilidad Única
 * AppLogger: Abierto pero Cerrado
 * AppLogger: Inversión de dependencias. Los módulos de alto nivel
 * son independientes de los detalles de implementación
 * */