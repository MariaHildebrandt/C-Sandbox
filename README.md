# C-Sharp-Sandbox
Repository for C# Basics

### HousePropertyApplication.cs

- Classes and Inheritance (Constructors, Destructors, Getter and Setters)
- Arrays of Objects
- For-Loop
- If, Else
- override functions
- Polymorphism

Landlord can create and manage Houses and Residents, Employees

### AnimalInterface.cs

- Class Bird inherits from IAnimal Interface and IComparable Interface
- Generic List (Bird Objects)
- forEach-Loop

### CarStruct.cs

- Struct for Car Objects

### GenericArray.cs

- contains class for generic arrays to instantiate arrays of any type (int, char, String, bool...)

### Personal Notes

- <b>namespace</b> ->keep one set of names separate from another. The class names declared in one namespace do not conflict with the same class names declared in another.
- One can define one namespace inside another namespace 

#### Thread Programming
- saves wastage of CPU cycle and increases efficiency of an application
- execute more than one task at a time -> devide application into smaller threads
- Life Cycle: starts when an object of the <b>System.Threading.Thread class</b> is created. Ends when the thread is terminated or completes execution
- States: unstarted(instance of thread is created but Start method not called), ready(waiting CPU cycle), not runnable(Blocked by I/O operations), dead(completed or aborted)
- first thread to be executed: Main Thread (CurrentThread Property)
- following snippet will print out: This is MainThread

```bash
using System;
using System.Threading;

namespace MultithreadingApplication
{
   class MainThreadProgram
   {
      static void Main(string[] args)
      {
         Thread th = Thread.CurrentThread;
         th.Name = "MainThread";
         Console.WriteLine("This is {0}", th.Name);
         Console.ReadKey();
      }
   }
}
```
- besides "currentThread" the Thread class has selvel other properties like isAlive, ExecutionContext, Priority, ThreadState etc.
- and several methods like: public void Abort()(-> ThreadAbortException ), public void Start(), public static void Sleep(int millisecondsTimeout) etc
