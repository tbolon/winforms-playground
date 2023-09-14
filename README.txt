# Windows Forms Playground

This repository contains projects used to demonstrate or tests Windows Forms features and/or issues.

# Requirement

* You have to edit the `Nuget.Config` file so that it correctly maps to the `local-packages` folder.
* You have to be sure that the new preview Windows Forms out-of-process designer is enabled for .NET apps
* You have to be sure that the new preview Windows Forms out-of-process designer for .NET Framework apps is enabled or disabled depending on the configuration.


# Control library support

6 configurations are tested :

- 1 app targeting .NET Framework 4.8, using the visual studio integrated designer (InProc)
- 1 app targeting .NET 7, using the new out-of-proc designer (OutProc)
- 1 app targeting .NET Framework 4.8, using the new out-of-proc designer (OutProc) by enabling the preview feature

For each app, we added a reference to the control library using:

- project reference where the project is also available in the solution
- package reference 

We have to create one solution for projects references and one solution for packages references, since visual studio will choke when mixing 

For each configuration, we tested different features :

1) Does visual studio automatically adds the custom control in the toolbox ?
2) Does visual studio uses the custom icon defined in the custom control using `ToolboxBitmap`
3) Does visual studio includes in the toolbox the items added manually via the "Add Items..." context menu in the toolbox ?
   We expect that this feature is only available for NetFx apps
4) Does the document outline window uses the custom icons ?


|                        | Project NetFx InProc | Package NetFx InProc | Project NetFx OutProc | Package NetFx OutProc | Project NetCore OutProc | Package NetCore OutProc |
|------------------------|:--------------------:|:--------------------:|:---------------------:|:---------------------:|-------------------------|-------------------------|
| Toolbox Auto Items     |           ✅          |           ✅          |           ❌           |           ✅           |            ✅            |            ✅            |
| Control Custom Icon    |           ❌          |           ❌          |           ❌           |           ✅           |            ✅            |            ✅            |
| Toolbox Manual Items   |          ✅¹          |           ✅          |           ❌           |           ❌           |            ✖️²            |            ✖️²            |
| Document Outline Icons |           ✅          |           ✅          |           ✅           |           ✅           |            ✅            |            ✅            |

¹ : the manual items are briefly visible then overwritten by the project reference items
² : the manuel items are not expected to be available there