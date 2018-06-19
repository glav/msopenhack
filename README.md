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


# Links
https://github.com/kubernetes/helm/blob/master/docs/install.md

https://github.com/Azure/blackbelt-aks-hackfest/blob/master/labs/day1-labs/06-monitoring-k8s.md

https://pascalnaber.wordpress.com/2018/01/26/persistent-storage-and-volumes-using-kubernetes-on-azure-with-aks-or-azure-container-service/
