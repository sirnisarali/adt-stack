# Project Detail
The following code was officially made by BMI faculty teacher [Nisar Ali](https://github.com/sirnisarali) and was trialed and tested by his student [Aitzaz Imtiaz](https://github.com/AitzazImtiaz) of BSTRB. The following code can be tested by students using the ```.sln``` file directly if a Visual Studio instance is present on the device. You can try forking this and editing it in your own GitHub account.

# Download Guide
You can download the ```.zip``` file from here and use ```.sln``` to execute the implementation itself. On the other hand, tech-savy students may use ```git``` with Visual Studio installed and run the following commands:
```
git clone https://github.com/sirnisarali/adt-stack
```
Exceptional students may try using further [MSBuild](https://learn.microsoft.com/en-us/visualstudio/msbuild/how-to-build-specific-targets-in-solutions-by-using-msbuild-exe?view=vs-2022) and rely on it to run the code efficiently.
# Backgroud
A stack is an abstract data type in computer science that represents a collection of elements and performs two primary operations:

Push, which adds an element to the collection, and Pop, which removes the element that was added most recently but hasn't been removed yet.
Additionally, the value of the most recently added element can be returned by a peek operation without affecting the stack. By analogy, this structure is referred to as a stack, like a set of plates stacked on top of one another.

As with a stack of physical objects, this structure makes it simple to take an item off the top of the stack, but accessing a datum deeper in the stack may require taking off multiple other items first. Considered as a linear data structure, or more abstractly a sequential collection, the push and pop operations only take place at one end of the structure, which is referred to as the top of the stack. This order in which an element is added to or removed from a stack is referred to A stack can be implemented as a single-linked list and as a pointer to the top element thanks to this data structure. It is possible to implement a stack with a limit on its capacity. Stack overflow occurs when the stack is full but does not have enough space to accommodate additional elements. To implement depth-first search, a stack is required.
