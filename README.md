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

##### Create Threads
- Create new Threads by extending the Thread class
- extended Thread class then calls the Start() method to begin the child thread execution.
- sleep() method for making a thread pause for a specific period of time and is a way to manage Threads

```bash
using System;
using System.Threading;

namespace MultithreadingApplication
{
   class ThreadCreationProgram
   {
      public static void CallToChildThread()
      {
         Console.WriteLine("Child thread starts");
         
         // the thread is paused for 5000 milliseconds
         int sleepfor = 5000; 
         
         Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
         Thread.Sleep(sleepfor);
         Console.WriteLine("Child thread resumes");
      }
      
      static void Main(string[] args)
      {
         ThreadStart childref = new ThreadStart(CallToChildThread);
         Console.WriteLine("In Main: Creating the Child thread");
         Thread childThread = new Thread(childref);
         childThread.Start();
         Console.ReadKey();
      }
   }
}
```
- will print: 

```bash
In Main: Creating the Child thread
Child thread starts
Child Thread Paused for 5 seconds
Child thread resumes
```
##### Abort Threads
- The runtime aborts the thread by throwing a ThreadAbortException
- This exception cannot be caught, the control is sent to the finally block, if any.

```bash
using System;
using System.Threading;

namespace MultithreadingApplication
{
   class ThreadCreationProgram
   {
      public static void CallToChildThread()
      {
         try
         {
            Console.WriteLine("Child thread starts");
            
            // do some work, like counting to 10
            for (int counter = 0; counter <= 10; counter++)
            {
               Thread.Sleep(500);
               Console.WriteLine(counter);
            }
            
            Console.WriteLine("Child Thread Completed");
         }
         
         catch (ThreadAbortException e)
         {
            Console.WriteLine("Thread Abort Exception");
         }
         finally
         {
            Console.WriteLine("Couldn't catch the Thread Exception");
         }
      }
      
      static void Main(string[] args)
      {
         ThreadStart childref = new ThreadStart(CallToChildThread);
         Console.WriteLine("In Main: Creating the Child thread");
         Thread childThread = new Thread(childref);
         childThread.Start();
         
         //stop the main thread for some time
         Thread.Sleep(2000);
         
         //now abort the child
         Console.WriteLine("In Main: Aborting the Child thread");
         
         childThread.Abort();
         Console.ReadKey();
      }
   }
}
```
- will print:
```bash
In Main: Creating the Child thread
Child thread starts
0
1
2
In Main: Aborting the Child thread
Thread Abort Exception
Couldn't catch the Thread Exception 
```
