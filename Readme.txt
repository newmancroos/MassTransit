- Message Broker : Broker message between publisher and subscribers
- Producer / Publisher - An Application responsible for sending messager
- Consumer / Subscriber - An Application listening for the messages.
- Queue - Storage where messages are stored by the broker.


- RabbitMQ 	- is a open source message broker.
			- Suppots multiple protocals
				* AMQP 0-9-1 (Binary messaging protocal specification.
				* STOMP - Text based protocal
				* MQTT - Binary protocal
				* HTTP and Web Scoket

- Install RabbitMq on docker
	docker run --hostname my-rabbit --name ecom-rabbit -p 15672:15672 -p 15672:15672 rabbitmq:3-managemtnt



new changes