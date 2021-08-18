# Grbl-Panel
A control panel for Grbl

This fork is a going to be a port to C# and support later versions of the DotNet frameworks.

The migration plan is:

* Create a C# controls library so that the VB controls and components can be ported individually and tested using the VB Program
* Create a C# Winforms project with the ported VB main form, calling the ported controls for comparison against the VB Program
