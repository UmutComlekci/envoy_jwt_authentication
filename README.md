## Setup

Anyway, lets get started.  You'll need:

- [Go 11+](https://golang.org/dl/)
- [Get Envoy](https://www.getenvoy.io/):   The tutorial runs envoy directly here but you can use the docker image as well. 


### Start with docker-compose

You can simple use docker-compose file the testing.

```
docker-compose up --remove-orphans --build --force-recreate
```