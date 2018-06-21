# Microsoft OpenHack

## Challenges
- [Challenge 1](overview/challenge1.md)
- [Challenge 2](overview/challenge1.md)
- [Challenge 3](overview/challenge1.md)
- [Challenge 4](overview/challenge1.md)
- [Challenge 5a](overview/challenge5a.md)
- [Challenge 5b](overview/challenge5b.md)
- [Challenge 6a](overview/challenge6a.md)
- [Challenge 6b](overview/challenge6b.md)

## Notes
```
$az interactive
```

```
$az login 
```

```
$az group create --name giovani-rg --location australiaeast
```

```
$az aks create --resource-group giovani-rg  --name giovani-aks --node-count 1 --generate-ssh-keys
```

```
$az aks install-cli
```

```
$az aks get-credentials --resource-group giovani-rg --name giovani-aks
```

```
$az aks browse --resource-group giovani-rg --name giovani-aks
```

```
$kubctl apply -f .
```

```
$#kubectl get nodes 
```

```
$kubectl completion --help
```

```
$kubectl get endpoints
```

```
$kubectl describe service minicraft-server-service
```

```
$kubectl get services -w
```

--dry-run

## Scale
```
$az aks scale --name giovani-aks --node-count 3 --resource-group giovani-rg
```

## Links
- [Helm](https://github.com/kubernetes/helm/blob/master/docs/install.md)
- [Monitoring](https://github.com/Azure/blackbelt-aks-hackfest/blob/master/labs/day1-labs/06-monitoring-k8s.md)
- [Persistent Storage](https://pascalnaber.wordpress.com/2018/01/26/persistent-storage-and-volumes-using-kubernetes-on-azure-with-aks-or-azure-container-service/)