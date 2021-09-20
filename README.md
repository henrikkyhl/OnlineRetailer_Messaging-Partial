# OnlineRetailer_Messaging-Partial

This solution demonstrates how to use messaging in microservices.

The solution is Docker enabled, and it contains the following two microservices:
1) ProductApi
2) OrderApi

It is a partial solution to the Microservice Mini Project that you may complete or use as inspiration.

Beware that The OrderApi does not implement a hidden model. It uses only shared models defined in a class library project called "SharedModels". You need to implement hidden models as well to achieve a "bounded context", and thus minimize the coupling between services. There are also other things that you need to do to satisfy all the requirements for the Microservice Mini Project.

You can run the solution using Docker or Kubernetes.

To run the solution using Docker Compose, do the following:
1) Open the Startup classes for ProductApi and OrderApi.
2) In each of these Startup classes, modify the "cloudAMQPConnectionString" so that it connects to your own RabbitMQ Server.
3) Build the solution in release mode.
4) Open a command prompt and navigate to the folder of the solution.
5) Run "docker-compose up -d"
6) Run "docker-compose ps". Note the HTTP ports that the two services expose to the outside world.
7) Open Postman and import the solution's Postman collection (it is in the solution's Postman folder).
8) Try the different HTTP requests defined in the Postman collection (remember to replace port numbers with the port numbers from the output of the "docker-compose ps" command.

To run the solution using Kubernetes, do the following:
1) Make sure that Kubernetes is enabled and running inside your Docker Desktop
2) Perform step 1-4 mentioned above (running the solution using Docker Compose)
3) In the command prompt, navigate to the Kubernetes folder inside the solution folder
4) Publish your ProductApi and OrderApi images to Docker Hub (Kubernetes can only run published Docker images)
5) Modify the following line in productapi.yml to match the name of your own image on Docker hub:
   image: henrikkyhl/productapi:latest
6) Modify the following line in orderapi.yml to match the name of your own image on Docker hub:
   image: henrikkyhl/orderapi:latest
7) Run the following two commands to deploy the two services of the solution to the Kubernetes cluster:
   kubectl apply -f productapi.yml
   kubectl apply -f orderapi.yml
8) Run the following commands to get information about the services running on the Kubernetes cluster:
   kubectl get services
   You should see that ProductApi exposes port 31001 outside the cluster, and that OrderApi exposes port 31002
9) Open your browser and make sure that you can call ProductApi and OrderApi to list products and orders:
   http://localhost:31001/products
   http://localhost:31002/orders
10)Open Postman and import the solution's Postman collection (it is in the solution's Postman folder).
11)Try the different HTTP requests defined in the Postman collection (remember to replace port numbers with the correct values)
12)When you are finished, delete ProductApi and OrderApi from the Kubernetes cluster by running the following commands:
   kubectl delete -f productapi.yml
   kubectl delete -f orderapi.yml
