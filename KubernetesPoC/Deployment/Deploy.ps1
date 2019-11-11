az login
az aks get-credentials --resource-group DEV --name panasonic-dev

kubectl create secret docker-registry panasonicdevcrsecret `
  --docker-server panasonicdevcr.azurecr.io `
  --docker-email stephen@ciandt.com `
  --docker-username panasonicdevcr `
  --docker-password k8vStysiT3iX0gGg/1ZEecWVnBMMx4pQ

kubectl apply -f kubernetespoc.yaml
