# Interfacer

Interfacer allows you to apply custom interfaces to 3rd party classes (such as the .NET Framework).  It works by automatically generating wrapper classes using Castle Project's [DynamicProxy](http://www.castleproject.org/projects/dynamicproxy/).

#### Why do I want this?

Using interfaces allows your code to be decoupled from the concrete implementation of its dependencies.  Objects and services can then be resolved through dependency injection and mocked in unit tests.

# Usage

Start with a class that doesn't currently implement an interface -- for example: [System.Threading.Semaphore](https://msdn.microsoft.com/en-us/library/system.threading.semaphore(v=vs.110).aspx). Let's create an interface for it.
```
[ApplyToInstance(typeof(Semaphore))]
public interface ISemaphore
{
    void WaitOne();
    int Release();
}
```

