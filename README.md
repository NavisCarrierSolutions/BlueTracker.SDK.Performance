![Build Status](https://ncs-fleet.visualstudio.com/_apis/public/build/definitions/36e4a17c-95ff-4c57-b1ae-af779fd7672c/28/badge)

# BlueTracker.SDK.Performance
This project is a C# wrapper of the Bluetracker REST API. It is used to easily query and modify Bluetracker entities in C#.

## Basic usage
This example explains how to query ships.

Install the package from **nuget.org**:
```
Install-Package BlueTracker.SDK.Performance
```

Create an **API key**. The key can be created via the **Company Manager** in the **Bluetracker** application.

Create the **ship client** and insert the **API key**:
```C#
var client = new BlueTracker.SDK.Performance.Clients.ShipClient(authorization: "<API-KEY>");
```
Query all ships:
```C#
var ships = client.GetAll();
```

## Clients
The package contains one client wrapper for each API resource. Each client contains methods to GET, POST, PUT and DELETE resources according to the API specification: https://api.bluetracker.one 

- ``BlueTracker.SDK.Performance.Clients.ShipClient``
- ``BlueTracker.SDK.Performance.Clients.ShipClassClient``
- ``BlueTracker.SDK.Performance.Clients.ShipBaseDataClient``
- ``BlueTracker.SDK.Performance.Clients.ShipClassBaseDataClient``
- ``BlueTracker.SDK.Performance.Clients.LegClient``
- ``BlueTracker.SDK.Performance.Clients.ReportClient``
- ``BlueTracker.SDK.Performance.Clients.VoyageClient``
- ``BlueTracker.SDK.Performance.Clients.EventClient``
- ``BlueTracker.SDK.Performance.Clients.HullModelClient``
- ``BlueTracker.SDK.Performance.Clients.HullEventClient``
- ``BlueTracker.SDK.Performance.Clients.HullInterruptionClient``
- ``BlueTracker.SDK.Performance.Clients.OwnerClient``
- ``BlueTracker.SDK.Performance.Clients.TagClient``
- ``BlueTracker.SDK.Performance.Clients.ConsumptionCurveClient``
- ``BlueTracker.SDK.Performance.Clients.SfocCurveClient``
- ``BlueTracker.SDK.Performance.Clients.OnboardSampleSourceClient``
- ``BlueTracker.SDK.Performance.Clients.OnboardSampleValueClient``
- ``BlueTracker.SDK.Performance.Clients.OnboardSampleSourceValueRangeClient``
