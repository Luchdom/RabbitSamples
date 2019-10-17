### Running RabbitMQ on docker
##### Download the RabbitMQ image
```shell
docker pull rabbitmq:3-management
```
##### Start the RabbitMQ docker image
```shell
docker run -d --hostname my-rabbit --name rabbit -p 15672:15672 -p 5672:5672  rabbitmq:3-management
```
Open http://localhost:15672/ (guest/guest) to see if it is working.
