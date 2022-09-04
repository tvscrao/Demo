# DemoProj
Create a .Net Core service (use the IDE you like best) implementing a GraphQL interface https://graphql.org/learn/. Use HotChocolate https://chillicream.com/docs/hotchocolate as the server implementation of GraphQL (in the docs you will find examples how to write a simple query). Implement the GraphQL query so that it accesses a public Rest API (for example https://swapi.dev/) and returns the data to the frontend. Abstract the remote API call so that you can mock it and write a mocked unit test. The mock will replace the external api dependency and will return dummy test data instead. Use Moq https://riptutorial.com/moq as the mocking framework and XUnit as the testing framework. Use the Banana Cake Pop UI to test the functionality (nothing really to do, it is integrated into the HotChocolate framework, you just need to write the GraphQL query). You must not write any client-side code.

Though the task is simple, try to use a good architecture you would use for a slightly bigger project (DDD not required) . Use Clean Code principles in your code as best as you can.

Use a public CVS like GitHub or Bitbucket to store your code and send us the URL to the code repository.
