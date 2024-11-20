PROJECT_NAME=auth_service_db
DOCKER_COMPOSE_PATH=$(CURDIR)/deployments/docker-compose.yaml

.PHONY: env
env:
	./scripts/create_env.sh

.PHONY: up-service
up-service: 
	docker-compose -p $(PROJECT_NAME) -f $(DOCKER_COMPOSE_PATH) up -d

.PHONY: down-service
down-service:
	docker-compose -p $(PROJECT_NAME) -f $(DOCKER_COMPOSE_PATH) down