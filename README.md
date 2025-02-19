# C# Unexpected Object Property Behavior

This repository demonstrates a subtle bug in C# related to object property copying.  When creating a new object by passing a property of an existing object, changes to the original object's property might not reflect in the new object as expected. This is because value types are copied, while reference types are not.  The example below uses integer (value type) but the bug may occur with other types.

## The Problem

The code in `bug.cs` showcases how modifying a property in one object doesn't affect the property in the newly created object if the property is a value type.  This is because value types are copied by value.  If a reference type were used instead, it could cause unintended sharing of data and lead to even more complex and harder to track issues.

## The Solution

The `bugSolution.cs` file provides a solution. The solution is based on whether it's expected to copy or to have the second object refer to the first object. If a copy is needed, the solution provides an explicit copy constructor. If it's intended that the second object refer to the first, then the code needs to be refactored to reflect this design decision.