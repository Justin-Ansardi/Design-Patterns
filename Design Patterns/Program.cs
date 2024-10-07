using Design_Patterns.Clients;
using Design_Patterns.Creational.AbstractFactory;
using Design_Patterns.Creational.Builder;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using static Design_Patterns.Clients.AbstractFactoryBuilderHybridThingClient;



//Factory method with Builder reuse!
var factory = new AbstractFactoryBuilderHybridThingClient(new NissanFactory());
var userInput = Design_Patterns.Models.Enums.CarModel.Rouge;

factory.BuildAutoFromAbstractFactory(userInput);

//Orginal Builder functionality
BuilderClient.BuildAuto();


