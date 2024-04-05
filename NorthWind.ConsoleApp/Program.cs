﻿HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application Started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azúcar Refinada");

/*     IMPLEMENTACIONES DE TRES PRINCIPIOS IMPORTANTES
 * AppLogger y los Writers: Responsabilidad Única
 * AppLogger: Abierto pero Cerrado
 * AppLogger: Inversión de dependencias. Los módulos de alto nivel
 * son independientes de los detalles de implementación
 * */