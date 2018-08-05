Hi and Thank you for sending me this Test.

Part A:
1. Technologies, Frameworks and Tools:
   VS.NET 2017, C#, Microsoft Unit Testing
2. Application Architecture:
   ASP.NET CORE Console App -> Domain Service
3. Solution Components:
   - 2 ASP.NET CORE Console applications
   - Domain Services Implementation
   - Unit testing project
   - Release notes (this file).
4. Testing:
   - Unit testing using VS.NET
5. Functionalities:
   - API: GetFromEnd(int rankFromEnd)
   - API: ResverseString(string input)
   - API: ResverseString2(string input) [A more premitive implementation]

--------------------------------------------

Part B:
1. Technologies, Frameworks and Tools:
   VS.NET 2017, ASP.NET CORE 2, WebAPI2, Microsoft Unit Testing, Bootstrap 4, JQuery 10.0, DI/IoC
2. Application Architecture:
   WebAPI Client (In this example Web Browser/JavaScript) -> WebAPI Service -> Database
3. Code Architecture:
   WebApi -> Contracts ONLY (Abstract Interfaces)
   Contracts -> Concrete Implementation 
   Concrete Implementation
   Automatic Contracts to Implementation resolution using IoC
4. Solution Components:
   - WebAPI application
   - Sample web application (bundled in WebAPI for simplicity. Idealy they must be 2 seprate projects)
   - Contracts class library
   - Concrete Implementation
   - Database
   - Unit testing project
   - Release notes (this file) and screenshots.
5. Testing:
   - Unit testing using VS.NET
   - WebAPI testing using Google Postman
6. Functionalities:
   - WebAPI: 
      - Get all terms
	  - Get all terms sorted by term.
      - Save (Add or update a term).
      - Delete (Delete a terms)
7. Assumptions:
   - No WebAPI secuirty is required (Authentication or Authorization)
8. WebAPI documentation using Swagger.
