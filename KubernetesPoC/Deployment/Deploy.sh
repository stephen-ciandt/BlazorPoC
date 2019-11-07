az login
az aks get-credentials --resource-group DEV --name panasonic-dev

kubectl create secret docker-registry panasonicdevcrsecret
  --docker-server panasonicdevcr.azurecr.io
  --docker-email stephen@ciandt.com
  --docker-username panasonicdevcr
  --docker-password <password>

kubectl apply -f kubernetespoc.yaml
