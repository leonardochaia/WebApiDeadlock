# ASP.NET WebApi Deadlock
A solution containing interconnected web apis project reproducing a deadlock.

The deadlock occurs when a WebApi1, executes an HTTP request to WebApi2 which also executes an HTTP request to WebApi3. If you remove the WebApi2, and call directly the WebApi1 from the WebApi3 there are no issues.

We have been able to a void the issue by switching either of the WebApi projects to its own Application Pool, or by increasing the Application Pool's Worker Processes up to two.

Requirements for reproduction
  1. Running on IIS
  2. Same Application pool for all WebApi projects.
  3. Application pool with a single worker process
