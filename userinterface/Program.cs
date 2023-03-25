// See https://aka.ms/new-console-template for more information
using userinterface;

// Console.WriteLine("Hello, World!");

Coche ford = new Coche("123ABC", "Ford", "Ranger");

Secretario juan = new Secretario("jose", "Hernandez", 21, "Tortuguitas", "3522452", 10, "119362226", 120);
Secretario jorge = new Secretario("jorge", "Quintana", 21, "Bella vista", "3522452", 10, "119362226", 120);

Empleado franco = new Empleado("Franco", "Gonzalez", 25, "jose c paz", "4002285", 10, "1169962786", 100);


Supervisor cristian = new Supervisor("Cristian", "Mazza", 25, "san miguel", "4002285", 25, "1154558", 1000, "cuarto piso",ford, juan);








Console.WriteLine(franco.presentarse());
franco.aumentarSalario();
franco.cambiarSupervisor(cristian);
Console.WriteLine(franco.presentarse());


Console.WriteLine(cristian.presentarse());
cristian.aumentarSalario();
cristian.cambiarSecretario(jorge);
Console.WriteLine(cristian.presentarse());

Console.WriteLine(juan.presentarse());
juan.aumentarSalario();
juan.cambiarSupervisor(cristian);
Console.WriteLine(juan.presentarse());