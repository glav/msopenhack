$az interactive
$az login 
$az group create --name giovani-rg --location australiaeast
$az aks create --resource-group giovani-rg  --name giovani-aks --node-count 1 --generate-ssh-keys
$az aks install-cli
$az aks get-credentials --resource-group giovani-rg --name giovani-aks
$az aks browse --resource-group giovani-rg --name giovani-aks
$kubctl apply -f .
$#kubectl get nodes 


$kubectl completion --help
--dry-run
$kubectl get endpoints
$kubectl describe service minicraft-server-service
$kubectl get services -w

Scale
$az aks scale --name giovani-aks --node-count 3 --resource-group giovani-rg