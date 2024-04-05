﻿﻿using Microsoft.Extensions.DependencyInjection.Writers;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddFileWriter();
Builder.Services.AddConsoleWriter();
Builder.Services.AddDebugWriter();

Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application Started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azúcar Refinada");

/*     IMPLEMENTACIONES DE TRES PRINCIPIOS IMPORTANTES
 * AppLogger y los Writers: Responsabilidad Única
 * AppLogger: Abierto pero Cerrado
 * AppLogger: Inversión de dependencias. Los módulos de alto nivel
 * son independientes de los detalles de implementación
 * */