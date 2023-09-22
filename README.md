# OnlineRetailer_Messaging-Partial

This solution demonstrates how to use messaging in microservices.

The solution is Docker enabled, and it contains the following two microservices:

1) ProductApi
2) OrderApi

It is a partial solution to the Microservice Mini Project that you may complete or use as inspiration. To enable seamless portability between different platforms, the solution was NOT https enabled. The solution uses a RabbitMQ server that runs as a Docker container. If you want to use CloudAMQP instead of RabbitMQ in Docker, you need to change the cloudAMQPConnectionString in the Program classes for ProductApi and OrderApi.

Beware that all the models are implemented in a class library project called "SharedModels". You need to implement hidden models as well to achieve a "bounded context", and thus minimize the coupling between services. There are also other things that you need to do to satisfy all the requirements for the Microservice Mini Project.

You can run the solution using Docker or Kubernetes.

To run the solution in a command window using Docker Compose, do the following:
1) Build the solution in release mode.
2) Open a command window and navigate to the folder of the solution.
3) Run "docker-compose up -d"
4) Run "docker-compose ps". Note the HTTP ports that the two services expose to the outside world.
5) Open Postman and import the solution's Postman collection (it is in the solution's Postman folder).
6) Try the different HTTP requests defined in the Postman collection (remember to replace port numbers with the port numbers from the output of the "docker-compose ps" command.

To run the solution using Kubernetes, do the following:
1) Make sure that Kubernetes is enabled and running inside your Docker Desktop
2) Build the solution in release mode.
3) Open a command window and navigate to the folder of the solution.
4) In the command window, navigate to the Kubernetes folder inside the solution folder
5) Publish your ProductApi and OrderApi images to Docker Hub (Kubernetes can only run published Docker images)
6) Modify the following line in productapi.yml to match the name of your own image on Docker hub:
   image: henrikkyhl/productapi:latest
7) Modify the following line in orderapi.yml to match the name of your own image on Docker hub:
   image: henrikkyhl/orderapi:latest
8) Run the following two commands to deploy the two services of the solution to the Kubernetes cluster:
   kubectl apply -f productapi.yml
   kubectl apply -f orderapi.yml
9) Run the following commands to get information about the services running on the Kubernetes cluster:
   kubectl get services
   You should see that ProductApi exposes port 31001 outside the cluster, and that OrderApi exposes port 31002
10)Open your browser and make sure that you can call ProductApi and OrderApi to list products and orders:
   http://localhost:31001/products
   http://localhost:31002/orders
11)Open Postman and import the solution's Postman collection (it is in the solution's Postman folder).
12)Try the different HTTP requests defined in the Postman collection (remember to replace port numbers with the correct values)
13)When you are finished, delete ProductApi and OrderApi from the Kubernetes cluster by running the following commands:
   kubectl delete -f productapi.yml
   kubectl delete -f orderapi.yml
