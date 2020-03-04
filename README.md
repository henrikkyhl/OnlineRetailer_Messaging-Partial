# OnlineRetailer_Messaging-Partial

This solution demonstrates how to use messaging to implement choreography in microservices.

The solution is Docker enabled, and it contains the following two microservices:
1) ProductApi
2) OrderApi

It is a partial solution to the Microservice Mini Project that you may complete or use as inspiration.

Beware that all the models are implemented in a class library project called "SharedModels". You need to implement hidden models as well to achieve a "bounded context", and thus minimize the coupling between services. There are also other things that you need to do to satisfy all the requirements for the Microservice Mini Project.

To run the solution, do the following:
1) Open the Startup classes for ProductApi and OrderApi.
2) In each of these Startup classes, modify the "cloudAMQPConnectionString" so that it connects to your own RabbitMQ Server.
3) Build the solution in release mode.
4) Open a command prompt and navigate to the folder of the solution.
5) Run "docker-compose up -d"
6) Run "docker-compose ps". Note the HTTP ports that the two services expose to the outside world.
7) Open Postman and import the solution's Postman collection (it is in the solution's Postman folder).
8) Try the different HTTP requests defined in the Postman collection (remember to replace port numbers with the port numbers from the output of the "docker-compose ps" command.
