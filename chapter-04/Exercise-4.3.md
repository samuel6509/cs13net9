1. What does the C# keyword void mean?
  . Void means nothing is going to be returned 
2. What are some differences between imperative and functional programming styles?
  IMPERITIVE:
  .uses mutable variables / override 
  .program state changes over time 
  . give computer step by step instructions
  FUNCTIONAL:
  . immutable variables / create a new variable instead
  . avoids changing state at all costs 
  . describe the transformation of data
3. In VS Code or Visual Studio, what is the difference between pressing F5, Ctrl or Cmd + F5, Shift + F5, and Ctrl or Cmd + Shift + F5?
  . F5 = start debugging
  . CMD + F5 = start without debugging 
  . SHIFT + F5 = stop debugging
  . CMD + SHIFT + F5 = restart debugging
4. Where does the Trace.WriteLine method write its output to?
  . outputs to the output window
5. What are the five trace levels?
  . off = turns tracing off 
  . critical = fatal errors causing application to fail
  . error = errors that occour that do not cause application to fail
  . warning = potential problems or unexpected situations
  . information = general info about application flow
6. What is the difference between the Debug and Trace classes?
  . Debug code is removed from release builds whereas trace code remains
7. When writing a unit test, what are the three “A”s?
  . Arrange: Declaring variables for input / output
  . Act: Executes the unit that i want testing
  . Assert: stating what the outcome of the test is expected to be, if all correct then all tests should pass
8. When writing a unit test using xUnit, which attribute must you decorate the test methods with?
  . [fact] || [theory]
9. What dotnet command executes xUnit tests?
  . dotnet test
10. What statement should you use to rethrow a caught exception named ex without losing the stack trace?
  . throw;
  . this rethrows without losing the stack trace