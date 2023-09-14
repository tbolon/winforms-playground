# Winforms designer and VS Toolbox Package references management

This project describe how Visual Studio handles controls libraries referenced through a nuget package.

This has been examined using the latest visual studio preview available: 17.8.0 Preview 1.0

## Setup

We enumerates all limitations and differences between the new out-of-proc designer and the legacy visual studio integrated designer.

We consider these two setup, plus some specific cases :

- Project `WindowsFormsNetFxApp` is a .NET 4.8 project (in-proc designer) which uses the legacy csproj SDK but uses `<PackageReference>`
- Project `WindowsFormsNetFxConfigApp` is a .NET 4.8 project (in-proc designer) which uses the legacy `packages.config` file to reference packages.
- Project `WinFormNetCoreApp` is a .NET 7.0 app which uses the new designer.
- Project `WinFormNetCoreThenFxApp` is a multi-target .NET 7.0 then .NET 4.8 app (order matters) which uses the new designer.
- Project `WinFormNetFxThenCoreApp` is a multi-target .NET 4.8 then 7.0 app (order matters) which uses the old designer.

The goal is to observe how visual studio handles the nuget package references and allow the user to drop control using the Toolbox.

## Features observed

There are multiple features tracked:

- How does visual studio show the library (package) containing the controls in the Toolbox?  
  It's supposed to use the `assembly: AssemblyProduct` attribute [as stated in a github comment](https://github.com/NuGet/Home/issues/6440#issuecomment-434827530).
- What visual studio displays in the tooltip of the control in the Toolbox?
  It's supposed to use the `DescriptionAttribute` of the control [as stated in the same github comment](https://github.com/NuGet/Home/issues/6440#issuecomment-434827530).
- Which icon visual studio uses to represent the control in the Toolbox?
  It's supposed to use the `ToolboxBitmap` of the control.
- (Bonus) Which icon visual studio uses in the document outline of the form?

## Observing

To check the visual studio behavior:

- open `PackageRefApps.sln`
- build the solution
- Open Form1.cs in each project and observe how the toolbox is populated.

## Results

Here are the results observed:

|                         | WindowsFormsNetFxConfigApp | WindowsFormsNetFxApp |  WinFormNetCoreApp | WinFormNetCoreThenFxApp | WinFormNetFxThenCoreApp |
|-------------------------|:--------------------------:|:--------------------:|:------------------:|:-----------------------:|:-----------------------:|
| Target Frameworks       |            net48           |         net48        |   net7.0-windows   |   net7.0-windows;net48  |   net48;net7.0-windows  |
| Designer Used           |        Visual Studio       |     Visual Studio    |     Out-of-Proc    |       Out-of-Proc       |      Visual Studio      |
| csproj SDK              |        Legacy csproj       |     Legacy csproj    |       New SDK      |         New SDK         |         New SDK         |
| Package reference style |       packages.config      |  &lt;PackageReference&gt;  | &lt;PackageReference&gt; |    &lt;PackageReference&gt;   |    &lt;PackageReference&gt;   |
| Toolbox populated?      |              ❌             |           ✅          |          ✅         |            ✅            |            ✅            |
| Uses assmebly Product?  |                            |           ✅          |          ❌         |            ❌            |            ✅            |
| Enhanced tooltip?       |                            |           ✅          |          ❌         |            ❌            |            ✅            |
| Control custom icon?    |                            |           ❌          |          ✅         |            ✅            |            ❌            |


Here are the conclusions:

- The legacy packages.config format is not supported at all and should be avoided
- The visual studio integrated designer does use a lot of metadata from the package and the control, but ignore any custom icon.
- The out-of-proc designer is the opposite: it only supports custom icon and ignore everything else.


Suggested fixes:

- Visual Studio should support custom icons in the legacy designer, as it already inspect custom attributes set on the control.
- Out-of-proc designer should support enhanced descriptions on the control library and the control it-self.