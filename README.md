## Setup

Anyway, lets get started.  You'll need:

- [Go 11+](https://golang.org/dl/)
- [Get Envoy](https://www.getenvoy.io/):   The tutorial runs envoy directly here but you can use the docker image as well. 


### Start with docker-compose

You can simple use docker-compose file the testing.

```
docker-compose up --remove-orphans --build --force-recreate
```

### Get Token

```
curl --location --request POST 'http://localhost:8082/connect/token' \
--header 'Content-Type: application/x-www-form-urlencoded' \
--data-urlencode 'client_id=client' \
--data-urlencode 'client_secret=secret' \
--data-urlencode 'scope=api1' \
--data-urlencode 'grant_type=client_credentials'
```


## Known Bugs

- `envoy.filters.http.jwt_authn` return `Jwks remote fetch is failed` response. 